/*
 * Copyright (C) 2016 Vinicius Rogério Araujo Silva
 * 
 * This file is part of RAMvader-Darksiders.
 * 
 * RAMvader-Darksiders is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * RAMvader-Darksiders is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with RAMvader-Darksiders. If not, see <http://www.gnu.org/licenses/>.
 */

/* This file keeps definitions for code elements which are part of the low-level features of the trainer. */
using RAMvader.CodeInjection;
using System;

namespace TrainerApp
{
	/// <summary>Identifiers for all cheats available in the trainer.</summary>
	public enum ECheat
	{
		/// <summary>Identifier for the "Infinite Blue Souls" cheat.</summary>
		evCheatInfiniteHP,
		/// <summary>Identifier for the "Infinite Blue Souls" cheat.</summary>
		evCheatInfiniteBlueSouls,
	}





	/// <summary>Identifiers for all of the code caves injected into the game process' memory space,
	/// once the trainer gets attached to the game.</summary>
	public enum ECodeCave
	{
		/// <summary>Identifier for the code cave which keeps track of the player's HP variable's address.</summary>
		[CodeCaveDefinition( 0x52, 0x8D, 0x90, 0x00, 0x01, 0x00, 0x00, 0x89, 0x15, EVariable.evVarPtrPlayerHP, 0x5A, 0xF3, 0x0F, 0x10, 0x80, 0x00, 0x01, 0x00, 0x00, 0xC3 )]
		evCodeCaveGetPtrPlayerHP,
		/// <summary>Identifier for the "Infinite Blue Souls" code cave.</summary>
		[CodeCaveDefinition( 0x50, 0xB8, 0x2A, 0x2C, 0x0A, 0x00, 0x50, 0xDB, 0x04, 0x24, 0x58, 0xD9, 0x9E, 0x54, 0x06, 0x00, 0x00, 0x58, 0xF3, 0x0F, 0x10, 0x86, 0x54, 0x06, 0x00, 0x00, 0xC3 )]
		evCodeCaveInfiniteBlueSouls,
	}





	/// <summary>Identifiers for all variables injected into the game process' memory space,
	/// once the trainer gets attached to the game.</summary>
	public enum EVariable
	{
		/// <summary>Identifies the variable which keeps the pointer to the player's HP variable.</summary>
		[VariableDefinition( (UInt32) 0 )]
		evVarPtrPlayerHP,
	}
}