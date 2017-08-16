using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeHeroMonsterClassesPart2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Character hero = new Character();
            hero.Name = "Alex";
            hero.Health = 200;
            hero.DamageMaximum = 10;
            hero.AttackBonus = false;

            Character monster = new Character();
            monster.Name = "Dragon";
            monster.Health = 1000;
            monster.DamageMaximum = 20;
            monster.AttackBonus = true;

            Dice dice = new Dice();



            if (hero.AttackBonus)
            {
               
                monster.Defend(hero.Attack(dice));

              

            }

            if (monster.AttackBonus)
            {
               
                hero.Defend(monster.Attack(dice));


               
            }


            while (monster.Health > 0 && hero.Health > 0)
            {
                hero.Defend(monster.Attack(dice));





                monster.Defend(hero.Attack(dice));

                printStats(hero);
                printStats(monster);



            }
            displayResult(hero, monster);


        }


        private void displayResult(Character opponent1, Character opponent2)
        {
           

            if (opponent1.Health <= 0)
            {
                resultLabel.Text += String.Format("<p>{0} has defeated {1}!</p>", opponent2.Name, opponent1.Name);
            }

            else if (opponent2.Health <= 0)
            {
                resultLabel.Text += String.Format("<p>{1} has defeated {0}!</p>", opponent2.Name, opponent1.Name);
            }

            else
            {
                resultLabel.Text += String.Format("<p>Both {0} and {1} have died!</p>", opponent1.Name, opponent2.Name);

            }


        }

        private void printStats(Character character)
        {
            resultLabel.Text += String.Format("<p>{0} - Health: {1} - Max Damage: {2} - Attack Bonus: {3}</p>", character.Name, character.Health, character.DamageMaximum, character.AttackBonus);




        }

    }


    class Character
    {

        public string Name { get; set; }
        public int Health { get; set; }
        public int DamageMaximum { get; set; }
        public bool AttackBonus { get; set; }


        public int Attack(Dice dice)
        {

            dice.Sides = this.DamageMaximum;
            
            return dice.Roll();





        }




        public void Defend(int damage)
        {
            this.Health -= damage;

        }

    }

    class Dice
    {

        public int Sides { get; set; }
        Random random = new Random();

        public int Roll()
        {
           
            return random.Next(this.Sides);

        }



    }
}