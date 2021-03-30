open System.IO
open System.Linq

let rec DirectoryCopy
    (sourceDirName: string)
    (destDirName: string)
    (copySubDirs: bool)
    =
    // Get the subdirectories for the specified directory.
    let dir = DirectoryInfo sourceDirName
    let dirs = dir.GetDirectories ()

    // If the destination directory doesn't exist, create it.
    Directory.CreateDirectory destDirName |> ignore

    // Get the files in the directory and copy them to the new location.
    let files = dir.GetFiles ()

    for file in files do
        file.CopyTo (Path.Combine (destDirName, file.Name), false) |> ignore

    // If copying subdirectories, copy them and their contents to new location.
    if copySubDirs then
        for subdir in dirs do
            let tempPath = Path.Combine (destDirName, subdir.Name)
            DirectoryCopy subdir.FullName tempPath copySubDirs

let ReplaceInFile (fileName: string) (before: string) (after: string) =
    let beforeContent = fileName |> File.ReadAllText

    let afterContent = beforeContent.Replace (before, after)

    File.WriteAllText (fileName, afterContent)

let RemoveFoldersWithUnderscorePrefix (rootDir: string) =
    let dir = DirectoryInfo rootDir
    let dirs = dir.GetDirectories ()

    for subdir in dirs do
        if subdir.Name.StartsWith "_" then
            Directory.Delete (subdir.FullName, true)

let args = fsi.CommandLineArgs |> Seq.tail

if (Seq.length args) <> 2 then
    failwith "Invalid arguments."

let extensionDir = args.First ()
let publishDir = args.Last ()

DirectoryCopy extensionDir publishDir true

ReplaceInFile
    (Path.Combine (publishDir, "index.html"))
    "</head>"
    "<link rel=\"stylesheet\" type=\"text/css\" href=\"./stylesheet.css\" \/> </head>"

RemoveFoldersWithUnderscorePrefix publishDir
