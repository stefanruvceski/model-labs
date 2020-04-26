using System;
using System.Collections.Generic;
using System.Text;

namespace FTN.Common
{
	
	public enum DMSType : short
	{		
		MASK_TYPE							= unchecked((short)0xFFFF),

		TERMINAL							= 0x0001,
		CONNECTNODE 						= 0x0002,
		CONNECTNODECONT						= 0x0003,
        SERIESCOMPENS                       = 0x0004,
		ACLINESEGMENT						= 0x0005,
        DCLINESEGMENT                       = 0x0006,
    }

    [Flags]
	public enum ModelCode : long
	{
		IDOBJ								= 0x1000000000000000,
		IDOBJ_GID							= 0x1000000000000104,
		IDOBJ_ALIASNAME 					= 0x1000000000000207,
		IDOBJ_MRID							= 0x1000000000000307,
		IDOBJ_NAME							= 0x1000000000000407,	

        PWRSYSRES                           = 0x1100000000000000,

        TERMINAL                            = 0x1200000000010000,
        TERMINAL_CONNECTNODE                = 0x1200000000010109,
        TERMINAL_CONDEQ                     = 0x1200000000010209,

        CONNECTNODE                         = 0x1300000000020000,
        CONNECTNODE_DESC                    = 0x1300000000020107,
        CONNECTNODE_TERMINALS               = 0x1300000000020219,
        CONNECTNODE_CONNECTNODECONT         = 0x1300000000020309,

        CONNECTNODECONT                     = 0x1110000000030000,
        CONNECTNODECONT_CONNECTNODES        = 0x1110000000030119,

        EQUIPMENT                           = 0x1120000000000000,

        CONDEQ                              = 0x1121000000000000,
        CONDEQ_TERMINALS                    = 0x1121000000000119,

        SERIESCOMPENS                       = 0x1121100000040000,
        SERIESCOMPENS_R                     = 0x1121100000040105,
        SERIESCOMPENS_R0                    = 0x1121100000040205,
        SERIESCOMPENS_X                     = 0x1121100000040305,
        SERIESCOMPENS_X0                    = 0x1121100000040405,

        CONDUCTOR                           = 0x1121200000000000,

        ACLINESEGMENT                       = 0x1121210000050000,
        ACLINESEGMENT_R                     = 0x1121210000050105,
        ACLINESEGMENT_R0                    = 0x1121210000050205,
        ACLINESEGMENT_X                     = 0x1121210000050305,
        ACLINESEGMENT_X0                    = 0x1121210000050405,
        ACLINESEGMENT_BCH                   = 0x1121210000050505,
        ACLINESEGMENT_B0CH                  = 0x1121210000050605,
        ACLINESEGMENT_GCH                   = 0x1121210000050705,
        ACLINESEGMENT_G0CH                  = 0x1121210000050805,

        DCLINESEGMENT                       = 0x1121220000060000,
	}

    [Flags]
	public enum ModelCodeMask : long
	{
		MASK_TYPE			 = 0x00000000ffff0000,
		MASK_ATTRIBUTE_INDEX = 0x000000000000ff00,
		MASK_ATTRIBUTE_TYPE	 = 0x00000000000000ff,

		MASK_INHERITANCE_ONLY = unchecked((long)0xffffffff00000000),
		MASK_FIRSTNBL		  = unchecked((long)0xf000000000000000),
		MASK_DELFROMNBL8	  = unchecked((long)0xfffffff000000000),		
	}																		
}


