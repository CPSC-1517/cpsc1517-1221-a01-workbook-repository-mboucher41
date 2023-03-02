using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesDemo.Pages
{
    public class LottoQuickPicksModel : PageModel
    {
        //define properties that can be get/set from the page
        [BindProperty]
        public string? Username { get; set; }

        [BindProperty]
        public string? LottoType { get; set; } = "Lotto649";

        [BindProperty]
        public int QuickPicks { get; set; } = 3;

        //Define properties that can be get from the page
        public string? InfoMessage { get; private set; }
        public string? ErrorMessage { get; private set; }

        public List<int[]> QuickPickNumbers { get; private set; } = new();

        //define a post method handler
        public void OnPostGenerateNumbers()
        {
            if (string.IsNullOrWhiteSpace(Username))
            {
                ErrorMessage = "<strong>Username</strong> is required and cannot be blank";
            }
            else
            {
                //Remove any QuickPickNumbers list
                QuickPickNumbers.Clear();
                //Create a rng
                Random rng = new();
                //Create a new array of int for each quick pick
                for (int quickCount = 1; quickCount <= QuickPicks; quickCount++)
                {

                    //generate 6 unique between 1-9 for lotto649
                    if (LottoType.ToUpper() == "LOTTO649")
                    {
                        int[] currentLotoQuickPicks = new int[6];
                        for (int count = 1; count <= 6; count++)
                        {
                            currentLotoQuickPicks[count - 1] = rng.Next(1, 50);//could be altered to allow no duplicates
                        }
                        //Sort the contents of the array
                        Array.Sort(currentLotoQuickPicks);
                        //Add the array of into to our list
                        QuickPickNumbers.Add(currentLotoQuickPicks);
                    }
                    //generate 7 unique numbers between 1-50 for lotto max

                }
                InfoMessage = $"Hello {Username}";
            }
        }

        public IActionResult OnPostClear()
        {
            Username = null;
            InfoMessage = null;
            ErrorMessage = null;
            return RedirectToPage();
        }

        public void OnGet()
        {
        }      
    }
}
