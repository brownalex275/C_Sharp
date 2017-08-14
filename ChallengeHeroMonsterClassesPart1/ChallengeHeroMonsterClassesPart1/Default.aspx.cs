using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeHeroMonsterClassesPart1
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

            int damage = hero.Attack();
            monster.Defend(damage);
    
            

            

            damage = monster.Attack();
            hero.Defend(damage);


            displayResults(hero);
            displayResults(monster);
            
        
            

        }

    
        private void displayResults(Character character)
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

        Random random = new Random();
        public int Attack()
        {

            int damage = random.Next(this.DamageMaximum);
            return damage;
            
            
            
                
            
        }

        

        public void Defend(int damage)
        {
            this.Health -=  damage;
      
        }
    }



}