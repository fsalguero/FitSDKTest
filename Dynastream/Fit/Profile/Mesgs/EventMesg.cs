#region Copyright
////////////////////////////////////////////////////////////////////////////////
// The following FIT Protocol software provided may be used with FIT protocol
// devices only and remains the copyrighted property of Dynastream Innovations Inc.
// The software is being provided on an "as-is" basis and as an accommodation,
// and therefore all warranties, representations, or guarantees of any kind
// (whether express, implied or statutory) including, without limitation,
// warranties of merchantability, non-infringement, or fitness for a particular
// purpose, are specifically disclaimed.
//
// Copyright 2014 Dynastream Innovations Inc.
////////////////////////////////////////////////////////////////////////////////
// ****WARNING****  This file is auto-generated!  Do NOT edit this file.
// Profile Version = 11.0Release
// Tag = $Name: AKW11_000 $
////////////////////////////////////////////////////////////////////////////////

#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.IO;


namespace Dynastream.Fit
{
   /// <summary>
   /// Implements the Event profile message.
   /// </summary>  
   public class EventMesg : Mesg 
   {    
      #region Fields            
      static class DataSubfield
      {
         public static ushort TimerTrigger = 0;
         public static ushort CoursePointIndex = 1;
         public static ushort BatteryLevel = 2;
         public static ushort VirtualPartnerSpeed = 3;
         public static ushort HrHighAlert = 4;
         public static ushort HrLowAlert = 5;
         public static ushort SpeedHighAlert = 6;
         public static ushort SpeedLowAlert = 7;
         public static ushort CadHighAlert = 8;
         public static ushort CadLowAlert = 9;
         public static ushort PowerHighAlert = 10;
         public static ushort PowerLowAlert = 11;
         public static ushort TimeDurationAlert = 12;
         public static ushort DistanceDurationAlert = 13;
         public static ushort CalorieDurationAlert = 14;
         public static ushort FitnessEquipmentState = 15;
         public static ushort SportPoint = 16;
         public static ushort GearChangeData = 17;
         public static ushort Subfields = 18;
         public static ushort Active = Fit.SubfieldIndexActiveSubfield;
         public static ushort MainField = Fit.SubfieldIndexMainField;
      }     
      #endregion

      #region Constructors                 
      public EventMesg() : base(Profile.mesgs[Profile.EventIndex])               
      {                 
      }
      
      public EventMesg(Mesg mesg) : base(mesg)
      {
      }
      #endregion // Constructors

      #region Methods    
      ///<summary>      
      /// Retrieves the Timestamp field
      /// Units: s</summary>
      /// <returns>Returns DateTime representing the Timestamp field</returns>      
      public DateTime GetTimestamp()   
      {                
         return TimestampToDateTime((uint?)GetFieldValue(253, 0, Fit.SubfieldIndexMainField));                     
      }

      /// <summary>        
      /// Set Timestamp field
      /// Units: s</summary>
      /// <param name="timestamp_">Nullable field value to be set</param>      
      public void SetTimestamp(DateTime timestamp_) 
      {  
         SetFieldValue(253, 0, timestamp_.GetTimeStamp(), Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the Event field</summary>
      /// <returns>Returns nullable Event enum representing the Event field</returns>      
      public Event? GetEvent()   
      { 
         object obj = GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
         Event? value = obj == null ? (Event?)null : (Event)obj;
         return value;                     
      }

      /// <summary>        
      /// Set Event field</summary>
      /// <param name="event_">Nullable field value to be set</param>      
      public void SetEvent(Event? event_) 
      {  
         SetFieldValue(0, 0, event_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the EventType field</summary>
      /// <returns>Returns nullable EventType enum representing the EventType field</returns>      
      public EventType? GetEventType()   
      { 
         object obj = GetFieldValue(1, 0, Fit.SubfieldIndexMainField);
         EventType? value = obj == null ? (EventType?)null : (EventType)obj;
         return value;                     
      }

      /// <summary>        
      /// Set EventType field</summary>
      /// <param name="eventType_">Nullable field value to be set</param>      
      public void SetEventType(EventType? eventType_) 
      {  
         SetFieldValue(1, 0, eventType_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the Data16 field</summary>
      /// <returns>Returns nullable ushort representing the Data16 field</returns>      
      public ushort? GetData16()   
      {                
         return (ushort?)GetFieldValue(2, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set Data16 field</summary>
      /// <param name="data16_">Nullable field value to be set</param>      
      public void SetData16(ushort? data16_) 
      {  
         SetFieldValue(2, 0, data16_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the Data field</summary>
      /// <returns>Returns nullable uint representing the Data field</returns>      
      public uint? GetData()   
      {                
         return (uint?)GetFieldValue(3, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set Data field</summary>
      /// <param name="data_">Nullable field value to be set</param>      
      public void SetData(uint? data_) 
      {  
         SetFieldValue(3, 0, data_, Fit.SubfieldIndexMainField);
      }
      

      /// <summary>       
      /// Retrieves the TimerTrigger subfield</summary>      
      /// <returns>Nullable TimerTrigger enum representing the TimerTrigger subfield</returns>      
      public TimerTrigger? GetTimerTrigger() 
      { 
         return (TimerTrigger?)GetFieldValue(3, 0, DataSubfield.TimerTrigger);   
      }

      /// <summary> 
      /// 
      /// Set TimerTrigger subfield</summary>
      /// <param name="timerTrigger">Subfield value to be set</param>      
      public void SetTimerTrigger(byte? timerTrigger) 
      {  
         SetFieldValue(3, 0, timerTrigger, DataSubfield.TimerTrigger);
      }

      /// <summary>       
      /// Retrieves the CoursePointIndex subfield</summary>      
      /// <returns>Nullable ushort representing the CoursePointIndex subfield</returns>      
      public ushort? GetCoursePointIndex() 
      {                               
         return (ushort?)GetFieldValue(3, 0, DataSubfield.CoursePointIndex);   
      }

      /// <summary> 
      /// 
      /// Set CoursePointIndex subfield</summary>
      /// <param name="coursePointIndex">Subfield value to be set</param>      
      public void SetCoursePointIndex(ushort? coursePointIndex) 
      {  
         SetFieldValue(3, 0, coursePointIndex, DataSubfield.CoursePointIndex);
      }

      /// <summary>       
      /// Retrieves the BatteryLevel subfield
      /// Units: V</summary>      
      /// <returns>Nullable float representing the BatteryLevel subfield</returns>      
      public float? GetBatteryLevel() 
      {                               
         return (float?)GetFieldValue(3, 0, DataSubfield.BatteryLevel);   
      }

      /// <summary> 
      /// 
      /// Set BatteryLevel subfield
      /// Units: V</summary>
      /// <param name="batteryLevel">Subfield value to be set</param>      
      public void SetBatteryLevel(float? batteryLevel) 
      {  
         SetFieldValue(3, 0, batteryLevel, DataSubfield.BatteryLevel);
      }

      /// <summary>       
      /// Retrieves the VirtualPartnerSpeed subfield
      /// Units: m/s</summary>      
      /// <returns>Nullable float representing the VirtualPartnerSpeed subfield</returns>      
      public float? GetVirtualPartnerSpeed() 
      {                               
         return (float?)GetFieldValue(3, 0, DataSubfield.VirtualPartnerSpeed);   
      }

      /// <summary> 
      /// 
      /// Set VirtualPartnerSpeed subfield
      /// Units: m/s</summary>
      /// <param name="virtualPartnerSpeed">Subfield value to be set</param>      
      public void SetVirtualPartnerSpeed(float? virtualPartnerSpeed) 
      {  
         SetFieldValue(3, 0, virtualPartnerSpeed, DataSubfield.VirtualPartnerSpeed);
      }

      /// <summary>       
      /// Retrieves the HrHighAlert subfield
      /// Units: bpm</summary>      
      /// <returns>Nullable byte representing the HrHighAlert subfield</returns>      
      public byte? GetHrHighAlert() 
      {                               
         return (byte?)GetFieldValue(3, 0, DataSubfield.HrHighAlert);   
      }

      /// <summary> 
      /// 
      /// Set HrHighAlert subfield
      /// Units: bpm</summary>
      /// <param name="hrHighAlert">Subfield value to be set</param>      
      public void SetHrHighAlert(byte? hrHighAlert) 
      {  
         SetFieldValue(3, 0, hrHighAlert, DataSubfield.HrHighAlert);
      }

      /// <summary>       
      /// Retrieves the HrLowAlert subfield
      /// Units: bpm</summary>      
      /// <returns>Nullable byte representing the HrLowAlert subfield</returns>      
      public byte? GetHrLowAlert() 
      {                               
         return (byte?)GetFieldValue(3, 0, DataSubfield.HrLowAlert);   
      }

      /// <summary> 
      /// 
      /// Set HrLowAlert subfield
      /// Units: bpm</summary>
      /// <param name="hrLowAlert">Subfield value to be set</param>      
      public void SetHrLowAlert(byte? hrLowAlert) 
      {  
         SetFieldValue(3, 0, hrLowAlert, DataSubfield.HrLowAlert);
      }

      /// <summary>       
      /// Retrieves the SpeedHighAlert subfield
      /// Units: m/s</summary>      
      /// <returns>Nullable float representing the SpeedHighAlert subfield</returns>      
      public float? GetSpeedHighAlert() 
      {                               
         return (float?)GetFieldValue(3, 0, DataSubfield.SpeedHighAlert);   
      }

      /// <summary> 
      /// 
      /// Set SpeedHighAlert subfield
      /// Units: m/s</summary>
      /// <param name="speedHighAlert">Subfield value to be set</param>      
      public void SetSpeedHighAlert(float? speedHighAlert) 
      {  
         SetFieldValue(3, 0, speedHighAlert, DataSubfield.SpeedHighAlert);
      }

      /// <summary>       
      /// Retrieves the SpeedLowAlert subfield
      /// Units: m/s</summary>      
      /// <returns>Nullable float representing the SpeedLowAlert subfield</returns>      
      public float? GetSpeedLowAlert() 
      {                               
         return (float?)GetFieldValue(3, 0, DataSubfield.SpeedLowAlert);   
      }

      /// <summary> 
      /// 
      /// Set SpeedLowAlert subfield
      /// Units: m/s</summary>
      /// <param name="speedLowAlert">Subfield value to be set</param>      
      public void SetSpeedLowAlert(float? speedLowAlert) 
      {  
         SetFieldValue(3, 0, speedLowAlert, DataSubfield.SpeedLowAlert);
      }

      /// <summary>       
      /// Retrieves the CadHighAlert subfield
      /// Units: rpm</summary>      
      /// <returns>Nullable ushort representing the CadHighAlert subfield</returns>      
      public ushort? GetCadHighAlert() 
      {                               
         return (ushort?)GetFieldValue(3, 0, DataSubfield.CadHighAlert);   
      }

      /// <summary> 
      /// 
      /// Set CadHighAlert subfield
      /// Units: rpm</summary>
      /// <param name="cadHighAlert">Subfield value to be set</param>      
      public void SetCadHighAlert(ushort? cadHighAlert) 
      {  
         SetFieldValue(3, 0, cadHighAlert, DataSubfield.CadHighAlert);
      }

      /// <summary>       
      /// Retrieves the CadLowAlert subfield
      /// Units: rpm</summary>      
      /// <returns>Nullable ushort representing the CadLowAlert subfield</returns>      
      public ushort? GetCadLowAlert() 
      {                               
         return (ushort?)GetFieldValue(3, 0, DataSubfield.CadLowAlert);   
      }

      /// <summary> 
      /// 
      /// Set CadLowAlert subfield
      /// Units: rpm</summary>
      /// <param name="cadLowAlert">Subfield value to be set</param>      
      public void SetCadLowAlert(ushort? cadLowAlert) 
      {  
         SetFieldValue(3, 0, cadLowAlert, DataSubfield.CadLowAlert);
      }

      /// <summary>       
      /// Retrieves the PowerHighAlert subfield
      /// Units: watts</summary>      
      /// <returns>Nullable ushort representing the PowerHighAlert subfield</returns>      
      public ushort? GetPowerHighAlert() 
      {                               
         return (ushort?)GetFieldValue(3, 0, DataSubfield.PowerHighAlert);   
      }

      /// <summary> 
      /// 
      /// Set PowerHighAlert subfield
      /// Units: watts</summary>
      /// <param name="powerHighAlert">Subfield value to be set</param>      
      public void SetPowerHighAlert(ushort? powerHighAlert) 
      {  
         SetFieldValue(3, 0, powerHighAlert, DataSubfield.PowerHighAlert);
      }

      /// <summary>       
      /// Retrieves the PowerLowAlert subfield
      /// Units: watts</summary>      
      /// <returns>Nullable ushort representing the PowerLowAlert subfield</returns>      
      public ushort? GetPowerLowAlert() 
      {                               
         return (ushort?)GetFieldValue(3, 0, DataSubfield.PowerLowAlert);   
      }

      /// <summary> 
      /// 
      /// Set PowerLowAlert subfield
      /// Units: watts</summary>
      /// <param name="powerLowAlert">Subfield value to be set</param>      
      public void SetPowerLowAlert(ushort? powerLowAlert) 
      {  
         SetFieldValue(3, 0, powerLowAlert, DataSubfield.PowerLowAlert);
      }

      /// <summary>       
      /// Retrieves the TimeDurationAlert subfield
      /// Units: s</summary>      
      /// <returns>Nullable float representing the TimeDurationAlert subfield</returns>      
      public float? GetTimeDurationAlert() 
      {                               
         return (float?)GetFieldValue(3, 0, DataSubfield.TimeDurationAlert);   
      }

      /// <summary> 
      /// 
      /// Set TimeDurationAlert subfield
      /// Units: s</summary>
      /// <param name="timeDurationAlert">Subfield value to be set</param>      
      public void SetTimeDurationAlert(float? timeDurationAlert) 
      {  
         SetFieldValue(3, 0, timeDurationAlert, DataSubfield.TimeDurationAlert);
      }

      /// <summary>       
      /// Retrieves the DistanceDurationAlert subfield
      /// Units: m</summary>      
      /// <returns>Nullable float representing the DistanceDurationAlert subfield</returns>      
      public float? GetDistanceDurationAlert() 
      {                               
         return (float?)GetFieldValue(3, 0, DataSubfield.DistanceDurationAlert);   
      }

      /// <summary> 
      /// 
      /// Set DistanceDurationAlert subfield
      /// Units: m</summary>
      /// <param name="distanceDurationAlert">Subfield value to be set</param>      
      public void SetDistanceDurationAlert(float? distanceDurationAlert) 
      {  
         SetFieldValue(3, 0, distanceDurationAlert, DataSubfield.DistanceDurationAlert);
      }

      /// <summary>       
      /// Retrieves the CalorieDurationAlert subfield
      /// Units: calories</summary>      
      /// <returns>Nullable uint representing the CalorieDurationAlert subfield</returns>      
      public uint? GetCalorieDurationAlert() 
      {                               
         return (uint?)GetFieldValue(3, 0, DataSubfield.CalorieDurationAlert);   
      }

      /// <summary> 
      /// 
      /// Set CalorieDurationAlert subfield
      /// Units: calories</summary>
      /// <param name="calorieDurationAlert">Subfield value to be set</param>      
      public void SetCalorieDurationAlert(uint? calorieDurationAlert) 
      {  
         SetFieldValue(3, 0, calorieDurationAlert, DataSubfield.CalorieDurationAlert);
      }

      /// <summary>       
      /// Retrieves the FitnessEquipmentState subfield</summary>      
      /// <returns>Nullable FitnessEquipmentState enum representing the FitnessEquipmentState subfield</returns>      
      public FitnessEquipmentState? GetFitnessEquipmentState() 
      { 
         return (FitnessEquipmentState?)GetFieldValue(3, 0, DataSubfield.FitnessEquipmentState);   
      }

      /// <summary> 
      /// 
      /// Set FitnessEquipmentState subfield</summary>
      /// <param name="fitnessEquipmentState">Subfield value to be set</param>      
      public void SetFitnessEquipmentState(byte? fitnessEquipmentState) 
      {  
         SetFieldValue(3, 0, fitnessEquipmentState, DataSubfield.FitnessEquipmentState);
      }

      /// <summary>       
      /// Retrieves the SportPoint subfield</summary>      
      /// <returns>Nullable uint representing the SportPoint subfield</returns>      
      public uint? GetSportPoint() 
      {                               
         return (uint?)GetFieldValue(3, 0, DataSubfield.SportPoint);   
      }

      /// <summary> 
      /// 
      /// Set SportPoint subfield</summary>
      /// <param name="sportPoint">Subfield value to be set</param>      
      public void SetSportPoint(uint? sportPoint) 
      {  
         SetFieldValue(3, 0, sportPoint, DataSubfield.SportPoint);
      }

      /// <summary>       
      /// Retrieves the GearChangeData subfield</summary>      
      /// <returns>Nullable uint representing the GearChangeData subfield</returns>      
      public uint? GetGearChangeData() 
      {                               
         return (uint?)GetFieldValue(3, 0, DataSubfield.GearChangeData);   
      }

      /// <summary> 
      /// 
      /// Set GearChangeData subfield</summary>
      /// <param name="gearChangeData">Subfield value to be set</param>      
      public void SetGearChangeData(uint? gearChangeData) 
      {  
         SetFieldValue(3, 0, gearChangeData, DataSubfield.GearChangeData);
      }    
      ///<summary>      
      /// Retrieves the EventGroup field</summary>
      /// <returns>Returns nullable byte representing the EventGroup field</returns>      
      public byte? GetEventGroup()   
      {                
         return (byte?)GetFieldValue(4, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set EventGroup field</summary>
      /// <param name="eventGroup_">Nullable field value to be set</param>      
      public void SetEventGroup(byte? eventGroup_) 
      {  
         SetFieldValue(4, 0, eventGroup_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the Score field
      /// Comment: Do not populate directly.  Autogenerated by decoder for sport_point subfield components</summary>
      /// <returns>Returns nullable ushort representing the Score field</returns>      
      public ushort? GetScore()   
      {                
         return (ushort?)GetFieldValue(7, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set Score field
      /// Comment: Do not populate directly.  Autogenerated by decoder for sport_point subfield components</summary>
      /// <param name="score_">Nullable field value to be set</param>      
      public void SetScore(ushort? score_) 
      {  
         SetFieldValue(7, 0, score_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the OpponentScore field
      /// Comment: Do not populate directly.  Autogenerated by decoder for sport_point subfield components</summary>
      /// <returns>Returns nullable ushort representing the OpponentScore field</returns>      
      public ushort? GetOpponentScore()   
      {                
         return (ushort?)GetFieldValue(8, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set OpponentScore field
      /// Comment: Do not populate directly.  Autogenerated by decoder for sport_point subfield components</summary>
      /// <param name="opponentScore_">Nullable field value to be set</param>      
      public void SetOpponentScore(ushort? opponentScore_) 
      {  
         SetFieldValue(8, 0, opponentScore_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the FrontGearNum field
      /// Comment: Do not populate directly.  Autogenerated by decoder for gear_change subfield components.  Front gear number. 1 is innermost.</summary>
      /// <returns>Returns nullable byte representing the FrontGearNum field</returns>      
      public byte? GetFrontGearNum()   
      {                
         return (byte?)GetFieldValue(9, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set FrontGearNum field
      /// Comment: Do not populate directly.  Autogenerated by decoder for gear_change subfield components.  Front gear number. 1 is innermost.</summary>
      /// <param name="frontGearNum_">Nullable field value to be set</param>      
      public void SetFrontGearNum(byte? frontGearNum_) 
      {  
         SetFieldValue(9, 0, frontGearNum_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the FrontGear field
      /// Comment: Do not populate directly.  Autogenerated by decoder for gear_change subfield components.  Number of front teeth.</summary>
      /// <returns>Returns nullable byte representing the FrontGear field</returns>      
      public byte? GetFrontGear()   
      {                
         return (byte?)GetFieldValue(10, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set FrontGear field
      /// Comment: Do not populate directly.  Autogenerated by decoder for gear_change subfield components.  Number of front teeth.</summary>
      /// <param name="frontGear_">Nullable field value to be set</param>      
      public void SetFrontGear(byte? frontGear_) 
      {  
         SetFieldValue(10, 0, frontGear_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the RearGearNum field
      /// Comment: Do not populate directly.  Autogenerated by decoder for gear_change subfield components.  Rear gear number. 1 is innermost.</summary>
      /// <returns>Returns nullable byte representing the RearGearNum field</returns>      
      public byte? GetRearGearNum()   
      {                
         return (byte?)GetFieldValue(11, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set RearGearNum field
      /// Comment: Do not populate directly.  Autogenerated by decoder for gear_change subfield components.  Rear gear number. 1 is innermost.</summary>
      /// <param name="rearGearNum_">Nullable field value to be set</param>      
      public void SetRearGearNum(byte? rearGearNum_) 
      {  
         SetFieldValue(11, 0, rearGearNum_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the RearGear field
      /// Comment: Do not populate directly.  Autogenerated by decoder for gear_change subfield components.  Number of rear teeth.</summary>
      /// <returns>Returns nullable byte representing the RearGear field</returns>      
      public byte? GetRearGear()   
      {                
         return (byte?)GetFieldValue(12, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set RearGear field
      /// Comment: Do not populate directly.  Autogenerated by decoder for gear_change subfield components.  Number of rear teeth.</summary>
      /// <param name="rearGear_">Nullable field value to be set</param>      
      public void SetRearGear(byte? rearGear_) 
      {  
         SetFieldValue(12, 0, rearGear_, Fit.SubfieldIndexMainField);
      }
                        
      #endregion // Methods
   } // Class
} // namespace
