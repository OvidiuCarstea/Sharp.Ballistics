﻿namespace Sharp.Ballistics.Abstractions
{
    public class AmmoInfo
    {
        public DragFunction DragFunction { get; set; }

        //175 gr .308 Match-King HPBT BC -> 0.505
        //note : BC factors in weight
        public double BC { get; set; }

        public string Name { get; set; }
        
        public double MuzzleVelocity { get; set; }    
    }
}