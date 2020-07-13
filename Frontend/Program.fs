module Frontend.Program

open Ooui
open Xamarin.Forms

[<EntryPoint>]
let main argv =
    Forms.Init()
    let app = new GWallet.Frontend.XF.App()
    UI.Publish("/", app.MainPage.GetOouiElement());
    0 // return an integer exit code
