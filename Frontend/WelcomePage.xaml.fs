namespace Frontend

open Xamarin.Forms
open Xamarin.Forms.Xaml

type WelcomePage() =
    inherit ContentPage()
    let _ = base.LoadFromXaml(typeof<WelcomePage>)
