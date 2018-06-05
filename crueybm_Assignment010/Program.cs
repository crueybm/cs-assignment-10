/*
 * Name: Brandon Cruey 
 * email: crueybm@mail.uc.edu
 * Class: Contemporary Programming
 * Date: 11/02/2017
 * Assignment: 010
 * Description:  This console application takes previously provided classes, and uses them to create overloaded operators.
 * The operators are then used, and the results are printed.
 * Citation: 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crueybm_Assignment010
{
    class Program
    {
        static void Main(string[] args)
        {
            Skeleton s1 = new Skeleton(10, 10, 10, 10, "None", 10, "Bone", "Hank");                     //Declares Skeleton s1
            Skeleton s2 = new Skeleton(10, 10, 10, 10, "None", 10, "Bone", "Bill");                     //Declares Skeleton s2
            Skeleton s3 = new Skeleton(10, 10, 10, 10, "None", 10, "Bone", "Dale");                     //Declares Skeleton s3
            Skeleton s4 = new Skeleton(10, 10, 10, 10, "None", 10, "Bone", "Boomhauer");                //Declares Skeleton s4
            BossDragon bd1 = new BossDragon(100, 50, 50, 10, "None", 100, "Cotton", "Shinbone Sword");  //Declares BossDragon bd1

            SkeletonArmy horde;     //Declares SkeletonArmy horde
            Emperor boss;           //Declares Emperor boss
            horde = s1 + s2;        //Adds s1 and s2
            Console.WriteLine("The army is comprised of " + horde.name);
            horde += s3;            //Adds s3 to the horde
            Console.WriteLine("The army is comprised of " + horde.name);
            horde += s4;            //Adds s4 to the horde
            Console.WriteLine("The army is comprised of " + horde.name);
            boss = bd1 + horde;     //Adds the BossDragon to the SkeletonArmy
            Console.WriteLine(boss.name);
        }
    }
}
