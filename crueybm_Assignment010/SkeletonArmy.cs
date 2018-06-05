/*
 * Name: Brandon Cruey 
 * email: crueybm@mail.uc.edu
 * Class: Contemporary Programming
 * Date: 11/02/2017
 * Assignment: 010
 * Description: This is a simple class to create a "SkeletonArmy" object.
 * Citation: 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crueybm_Assignment010
{
    class SkeletonArmy
    {
        public SkeletonArmy(String name)    //Creates SkeletonArmy constructor
        {
            this.name = name;
        }
        public String name { get; set; }    //Gets and sets the name value for a SkeletonArmy
    }
}
