﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace DRS_Mobile.Models
{
    #region MECHS
    public class Mech
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Variant { get; set; }
        public int WalkSpeed { get; set; }
        public int RunSpeed { get; set; }
        public int JumpSpeed { get; set; }
        public int Tonnage { get; set; }
        public int HeatSinks { get; set; }
        public bool Done { get; set; }

        public MechLocations mechLocations
        {
            get;
            set;
        }
    }
    public class LocationsArmor
    {
        public int HArmor { get; set; }
        public int CTArmor { get; set; }
        public int LRArmor { get; set; }
        public int RTArmor { get; set; }
        public int LAArmor { get; set; }
        public int RAArmor { get; set; }
        public int LLArmor { get; set; }
        public int RLArmor { get; set; }
        public int CTRArmor { get; set; }
        public int LTRArmor { get; set; }
        public int RTRArmor { get; set; }
    }

    public class LocationInternal
    {
        public int HInternal { get; set; }
        public int CTInternal { get; set; }
        public int LRInternal { get; set; }
        public int RTInternal { get; set; }
        public int LAInternal { get; set; }
        public int RAInternal { get; set; }
        public int LLInternal { get; set; }
        public int RLInternal { get; set; }
    }

    public class LocationSlots
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }

    public class MechLocations
    {
        public LocationsArmor Armor
        {
            get;set;
        }
        
        public LocationInternal Internals
        { get; set; }
       
    }

    public class MechConfigurations
    {
        public int Tonnage { get; set; }
        public decimal Standard { get; set; }
        public decimal Endo { get; set; }
        public int H { get; set; }
        public int CT { get; set; }
        public int LT { get; set; }
        public int RT { get; set; }
        public int LA { get; set; }
        public int RA { get; set; }
        public int LL { get; set; }
        public int RL { get; set; }
        public int MaxArmor { get; set; }

    }
    public class AmmoItems
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public int QuantityPerTon { get; set; }
        public decimal Weight { get; set; }
        public int Cost { get; set; }
        public int BV { get; set; }
    }

    public class EquipmentItems
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Description { get; set; }
        public int Heat { get; set; }
        public int Damage { get; set; }
        public string Minimum { get; set; }
        public string Short { get; set; }
        public string Medium { get; set; }
        public string Long { get; set; }
        public int Tonnage { get; set; }
        public int CriticalSlots { get; set; }
        public int AmmoID { get; set; }
        public int Cost { get; set; }
        public int BV { get; set; }
        public string EquipmentType { get; set; }
    }
    #endregion



    #region Forces  
    public class MechForces
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string ForceName { get; set; }
        public int WarchestPoints { get; set; }
    }

    public class MissionTypes
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Description { get; set; }
        public int Cost { get; set; }
        public int Objective1 { get; set; }
        public int Objective2 { get; set; }
        public int Objective3 { get; set; }
        public int Bonus1 { get; set; }
        public int Bonus2 { get; set; }
        public int Bonus3 { get; set; }
    }

    public class ForceMissions
    {
        public int ForceID { get; set; }
        public int MissionTypeID { get; set; }
        public int WarchestPointsPaid { get; set; }
        public int WarchestPointsObtained { get; set; }
    }


    public class ForceMechs
    {
        public int MechID { get; set; }
        public int ForceID { get; set; }
    }
    #endregion
}