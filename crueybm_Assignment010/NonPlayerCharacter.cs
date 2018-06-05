/*
 * Name: Brandon Cruey 
 * email: crueybm@mail.uc.edu
 * Class: Contemporary Programming
 * Date: 11/02/2017
 * Assignment: 010
 * Description:  This console application produces an example of how inheritance works.  
 * The main calls on the derived classes of "Entity" to play a "game" with them.
 * Citation: 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crueybm_Assignment010
{
    class NonPlayerCharacter : Entity
    {
        private String occupation;          //Declares String occupation
        private int rewardedExperience;     //Declares int rewardedExperience
        private Entity entity;              //Declares Entity entity

        public NonPlayerCharacter(int hitPoints, int attack, int defense, int speed, int rewardedExperience, String occupation) //Creates the "NonPlayerCharacter" constructor
            : base(hitPoints, attack, defense, speed)
        {
            setEntity(entity);                              //Sets entity
            setRewardedExperience(rewardedExperience);      //Sets rewardedExperience
            setOccupation(occupation);                      //Sets occupation
        }

        public Entity GetEntity() { return entity; }                        //Getter for entity
        public int getRewardedExperience() { return rewardedExperience; }   //Getter for rewardedExperience
        public String getOccupation() { return occupation; }                //Getter for occupation
        public void setEntity(Entity entity) { this.entity = entity; }      //Setter for entity
        public void setRewardedExperience(int rewardedExperience) { this.rewardedExperience = rewardedExperience; } //Setter for rewardedExperience
        public void setOccupation(String occupation) { this.occupation = occupation; }  //Setter for occupation
    }
}
