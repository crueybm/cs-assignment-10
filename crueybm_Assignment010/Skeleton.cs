/*
 * Name: Brandon Cruey 
 * email: crueybm@mail.uc.edu
 * Class: Contemporary Programming
 * Date: 11/02/2017
 * Assignment: 010
 * Description:  This class is used to create all skeletons for the "game".  
 * It is derived from both Entity and Enemy, so it inherits the variables from the base classes.
 * The variables "weapon" and "rattle" are both declared here.
 * Two overloaded "+" constructors also exist here.  
 * The first allows two Skeletons to be added to form a SkeletonArmy, 
 * and the second allows a Skeleton to be added to a Skeleton Army.
 * Citation: 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crueybm_Assignment010
{
    class Skeleton : Enemy
    {
        private Enemy enemy;        //Declares Enemy enemy
        private String weapon;      //Declares String weapon
        private String rattle;      //Declares String rattle

        public Skeleton(int hitPoints, int attack, int defense, int speed, String element, int rewardedExpreience, String weapon, String rattle) //Creates the "Skeleton" constructor
            : base(hitPoints, attack, defense, speed, element, rewardedExpreience)
        {
            setEnemy(enemy);        //Sets enemy
            setWeapon(weapon);      //Sets weapon
            setRattle(rattle);      //Sets rattle
        }

        public Entity getEnemy() { return enemy; }      //Getter for enemy
        public String getWeapon() { return weapon; }    //Getter for weapon
        public String getRattle() { return rattle; }    //Getter for rattle
        public void setEnemy(Enemy enemy) { this.enemy = enemy; }       //Setter for enemy
        public void setWeapon(String weapon) { this.weapon = weapon; }  //Setter for weapon
        public void setRattle(String rattle) { this.rattle = rattle; }  //Setter for rattle

        public static SkeletonArmy operator +(Skeleton a, Skeleton b)       //Creates the overloaded operator that takes two skeletons as arguments
        {
            SkeletonArmy skeletonArmy = new SkeletonArmy("");       //Creates new SkeletonArmy object
            skeletonArmy.name = a.rattle + ", " + b.rattle;         //Sets the object's name to a string containing the "rattles" of two skeletons
            return skeletonArmy;
        }

        public static SkeletonArmy operator +(SkeletonArmy sa, Skeleton b)  //Creates the overloaded operator that takes a Skeleton and a SkeletonArmy as arguments
        {
            SkeletonArmy skeletonArmy = new SkeletonArmy("");       //Creates a new SkeletonArmy object
            skeletonArmy.name = sa.name + ", " + b.rattle;          //Sets the object's name to a string containing multiple "rattle" strings
            return skeletonArmy;
        }
    }
}
