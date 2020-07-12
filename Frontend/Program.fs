module Frontend.Program

open Ooui
open Xamarin.Forms

[<EntryPoint>]
let main argv =
    Forms.Init()
    let page = new WelcomePage()
    UI.Publish("/", page.GetOouiElement());
    0 // return an integer exit code
