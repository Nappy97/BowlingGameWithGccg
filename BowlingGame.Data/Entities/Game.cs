
// <auto-generated> This file has been generated by Gccg on 2023-10-22 오후 8:31:31. </auto-generated>
#region using
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
 
#endregion

namespace BowlingGame.Data.Data;


#region GameMetadata
public class GameMetaData
{
    public int GameId {get; set;} 
		public DateTime GameDate {get; set;} 
	
	// The key type(s) is/are 
	// int _GameId {get; set;} 
}
#endregion

[MetadataType(typeof(GameMetaData))]
public partial class Game
{
}

