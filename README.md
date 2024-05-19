Current Basic Setup:

**Resources Folder:** contains our fonts, images, colors, and styles. Styles are used to customize appearances of stuff like buttons, textbars, headers, etc.

**MauiProgram.cs:** the basic scaffolding of the app. You can configure fonts, dependencies, activity lifecycyles, etc.

**App.xaml:** registers the colors and styles from the Resources folder.

**App.xaml.cs:** sets the main page to the AppShell

**AppShell.xaml:** the "shell" of the app. Directs to the main page. You can add more pages here, using ContentTemplates that are built in.

**MainPage.xaml:** holds the front end code for the main page of the app.

**MainPage.xaml.cs:** the backend logic for the main page, for example the button click counter.
