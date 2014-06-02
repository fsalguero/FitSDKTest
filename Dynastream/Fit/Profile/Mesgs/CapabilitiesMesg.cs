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
   /// Implements the Capabilities profile message.
   /// </summary>  
   public class CapabilitiesMesg : Mesg 
   {    
      #region Fields     
      #endregion

      #region Constructors                 
      public CapabilitiesMesg() : base(Profile.mesgs[Profile.CapabilitiesIndex])               
      {                 
      }
      
      public CapabilitiesMesg(Mesg mesg) : base(mesg)
      {
      }
      #endregion // Constructors

      #region Methods    
      
      /// <summary>
      /// 
      /// </summary>  
      /// <returns>returns number of elements in field Languages</returns>      
      public int GetNumLanguages() 
      {
         return GetNumFieldValues(0, Fit.SubfieldIndexMainField);
      }

      ///<summary>      
      /// Retrieves the Languages field
      /// Comment: Use language_bits_x types where x is index of array.</summary>
      /// <param name="index">0 based index of Languages element to retrieve</param>
      /// <returns>Returns nullable byte representing the Languages field</returns>      
      public byte? GetLanguages(int index)   
      {                
         return (byte?)GetFieldValue(0, index, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set Languages field
      /// Comment: Use language_bits_x types where x is index of array.</summary>      
      /// <param name="index">0 based index of languages</param>
      /// <param name="languages_">Nullable field value to be set</param>      
      public void SetLanguages(int index, byte? languages_) 
      {  
         SetFieldValue(0, index, languages_, Fit.SubfieldIndexMainField);
      }
          
      
      /// <summary>
      /// 
      /// </summary>  
      /// <returns>returns number of elements in field Sports</returns>      
      public int GetNumSports() 
      {
         return GetNumFieldValues(1, Fit.SubfieldIndexMainField);
      }

      ///<summary>      
      /// Retrieves the Sports field
      /// Comment: Use sport_bits_x types where x is index of array.</summary>
      /// <param name="index">0 based index of Sports element to retrieve</param>
      /// <returns>Returns nullable byte representing the Sports field</returns>      
      public byte? GetSports(int index)   
      {                
         return (byte?)GetFieldValue(1, index, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set Sports field
      /// Comment: Use sport_bits_x types where x is index of array.</summary>      
      /// <param name="index">0 based index of sports</param>
      /// <param name="sports_">Nullable field value to be set</param>      
      public void SetSports(int index, byte? sports_) 
      {  
         SetFieldValue(1, index, sports_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the WorkoutsSupported field</summary>
      /// <returns>Returns nullable uint representing the WorkoutsSupported field</returns>      
      public uint? GetWorkoutsSupported()   
      {                
         return (uint?)GetFieldValue(21, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set WorkoutsSupported field</summary>
      /// <param name="workoutsSupported_">Nullable field value to be set</param>      
      public void SetWorkoutsSupported(uint? workoutsSupported_) 
      {  
         SetFieldValue(21, 0, workoutsSupported_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the ConnectivitySupported field</summary>
      /// <returns>Returns nullable uint representing the ConnectivitySupported field</returns>      
      public uint? GetConnectivitySupported()   
      {                
         return (uint?)GetFieldValue(23, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set ConnectivitySupported field</summary>
      /// <param name="connectivitySupported_">Nullable field value to be set</param>      
      public void SetConnectivitySupported(uint? connectivitySupported_) 
      {  
         SetFieldValue(23, 0, connectivitySupported_, Fit.SubfieldIndexMainField);
      }
                        
      #endregion // Methods
   } // Class
} // namespace
