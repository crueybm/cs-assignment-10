/*
 * Name: Brandon Cruey 
 * email: crueybm@mail.uc.edu
 * Class: Contemporary Programming
 * Date: 11/02/2017
 * Assignment: 010
 * Description:  This class is used to create all Boss Dragons for the "game".  
 * It is derived from both Entity and Enemy, so it inherits the variables from the base classes.
 * The variable "loot" is declared here.
 * An overloaded "+" constructor also exists here, to add an "Emperor" to a "SkeletonArmy"
 * Citation: 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crueybm_Assignment010
{
    class BossDragon : Enemy
    {
        private Enemy enemy;    //Declares enemy
        private String loot;    //Declares loot
        private String name;    //Declares name

        public BossDragon(int hitPoints, int attack, int defense, int speed, String element, int rewardedExpreience, String name, String loot)  //Creates the "BossDragon" constructor
            : base(hitPoints, attack, defense, speed, element, rewardedExpreience)
        {
            setEnemy(enemy);    //Sets enemy
            setName(name);      //Sets name
            setLoot(loot);    //Sets loot
        }

        public Enemy getEnemy() { return enemy; }       //Getter for enemy
        public String getName() { return name; }        //Getter for name
        public String getLoot() { return loot; }      //Getter for loot
        public void setEnemy(Enemy enemy) { this.enemy = enemy; }   //Setter for enemy
        public void setName(String name) { this.name = name; }  //Setter for name
        public void setLoot(String loot) { this.loot = loot; }  //Setter for loot

        public static Emperor operator +(BossDragon d, SkeletonArmy sa) //Creates the overloaded operator that takes a BossDragon and a SkeletonArmy as arguments.
        {
            Emperor emperor = new Emperor("");                  //Creates a new Emperor object
            emperor.name = d.name + " rules over " + sa.name;   //Sets the object's name to a string containing the names of the BossDragon and SkeletonArmy
            return emperor;
        }
    }
}
