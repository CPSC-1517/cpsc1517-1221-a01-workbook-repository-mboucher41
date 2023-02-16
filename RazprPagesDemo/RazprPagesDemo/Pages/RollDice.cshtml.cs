using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazprPagesDemo.Pages
{
    public class RollDiceModel : PageModel
    {
        public void OnGet()
        {
           //DieImage = "/img/icons/000000/ffffff/1x1/delapouite/perspective-dice-six-faces-three.png";
        }
        public int DieValue { get; private set; }
        public string DieImage { get; private set; } = "/img/icons/000000/ffffff/1x1/delapouite/perspective-dice-six-faces-three.png";

        public string[] DieImages =
        {
            "/img/icons/000000/ffffff/1x1/delapouite/dice-six-faces-one.png",
            "/img/icons/000000/ffffff/1x1/delapouite/dice-six-faces-two.png",
            "/img/icons/000000/ffffff/1x1/delapouite/dice-six-faces-three.png",
            "/img/icons/000000/ffffff/1x1/delapouite/dice-six-faces-four.png",
            "/img/icons/000000/ffffff/1x1/delapouite/dice-six-faces-five.png",
            "/img/icons/000000/ffffff/1x1/delapouite/dice-six-faces-six.png"
        };

        [BindProperty]
        public int BetAmount { get; set; }

        [BindProperty]
        public int SelectedDieSide { get; set; }

        public string? InfoMessage { get; private set; }

        public void OnPost()
        {
            var ran = new Random();
            DieValue = ran.Next(1, 7);
            DieImage = DieImages[DieValue - 1];

            if (DieValue == SelectedDieSide)
            {
                InfoMessage = $"You won {BetAmount:C}.";
            }
            else
            {
                InfoMessage = $"You lost {BetAmount:C}.";
            }
        }
    }
}
