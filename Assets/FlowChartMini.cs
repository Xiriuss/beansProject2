using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowChartMini : MonoBehaviour
{
    //create fish stats
        //generate fish type as string (species)
        //generate fish length as float (0.1-10m)
            //generate fish size as string (small = 0.1-2, medium = 2.1-4, large = 4.1-6, gargantuan = 6.1-8, monstrous = 8.1-10)
                //generate fish weight as float (small = 1-5lbs, medium = 6-10lbs, large = 11-20lbs, gargantuan = 21-40lbs, monstrous = 40+lbs
        //generate fish colour as string (red, orange, yellow, green, blue, purple)
        //generate fish value as int (0-120 dollars)
            //generate fish rarity as string (common = 0-20, uncommon = 21-40, rare = 41-60, epic = 61-80, legendary = 81=100, mythical = 101-120)

    //when player presses casting button to cast rod
        //announce the player has caught a fish
        //announce fish stats (type string, length float, size string, weight float, colour string, value int and rarity string)

    //give player option between keep and discard
        //if player keeps, add 1 to aquarium total and add value to bucket value total
            //if kept fish is at least double the size of another fish in aquarium, that fish is eaten and removed
                //if fish is eaten, remove total dollar value and announce fish death
        //if player discards, announce that fish has been thrown back into the ocean
        //add 1 to round count
        //check round count

    //if player has reached round 10
        //calculate player's total and give grade based on value total
            //F = <40, D = 41-80, C = 81-100, B = 101-170, A = 170-500, A+ = >500
            //calculate win condition
                //if F or D then player has lost
                //if else then player has won
                    //display win or loss status

}