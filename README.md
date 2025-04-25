This is a web programming project that I did in a C# class. This site has multiple pages that showcase different features. 
Features are listed in order of page lineage:
 - Home(Start_Page.aspx) -> Home page that sets the session arrays vehiclecounter and savedvehilces
 - Donny's Vehicles(selector.aspx) -> Displays vehicles that are in the session when the page loads(Stored as Donny's vehicles)
      - Clicking the button selects a random vehicle from the session and displays the corresponding image
 - Save Your Own Vehicle(entry.aspx) -> Allows a user to save a vehicle of their own to the session
 - Show Saved Vehicles(user_display.aspx) -> Displays vehicles that the user has saved
 - Select a Favorite(favorite.aspx) -> Allows user to select favorite vehicles and save them to the session
 - Show Your Favorites(favorite_display.aspx) -> Displays favorite vehicles that were saved to the session
 - Upload an Image(upload.aspx) -> Allows user to upload a picture of their vehicle.

To run this code in Visual Studio:
 - Copy URL from the code on this github page
 - Clone repository in Visual Studio with URL
 - When project opens, set Start_Page.aspx as start page
 - Page will respond with an error if you don't specify a start page
