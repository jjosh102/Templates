using MudBlazor;
namespace Obaki.Template.Client.Shared.Themes;
public static class DefaultTheme
    {

        public static MudTheme ApplyTheme()
        {
            var defaultTheme = new MudTheme();
            var defaultDarkPallete = defaultTheme.PaletteDark;
            var defaultLightPallete = defaultTheme.Palette;
            //Dark 
            defaultDarkPallete.Dark = "#202020";
            defaultDarkPallete.Primary = "#F5F5F5";
            defaultDarkPallete.AppbarBackground = "#1E1E1E";
            defaultDarkPallete.DarkContrastText = "#F5F5F5";
            defaultDarkPallete.Background = "#121212";
            defaultDarkPallete.DrawerBackground = "#1E1E1E";
            defaultDarkPallete.Surface = "#1E1E1E";
            defaultDarkPallete.TextPrimary = "#ecf2f8";
            defaultDarkPallete.PrimaryContrastText = "161b22";
            defaultDarkPallete.AppbarText = "#F5F5F5";
            defaultDarkPallete.Tertiary = "#121212";

            //Light
            defaultLightPallete.Background = "#F9F9F9";

            return defaultTheme;
        }
    }