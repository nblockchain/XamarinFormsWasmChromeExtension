namespace Frontend

open System.Linq

open Xamarin.Forms


module Initialization =

    let internal LandingPage(): NavigationPage =
        let landingPage:Page =
            WelcomePage() :> Page

        let navPage = NavigationPage landingPage
        NavigationPage.SetHasNavigationBar(landingPage, false)
        navPage