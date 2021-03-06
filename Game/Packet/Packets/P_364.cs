﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace Emulator
{
    /// <summary>
    /// Visão do MOB - size 232
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct P_364
    {
        // Atributos
        public SHeader Header;        // 0 a 11			= 12

        public SPosition Position;    // 12 a 15		= 4

        public short ClientId;        // 16 a 17		= 2

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public byte[] NameBytes;    // 18 a 29		= 12

        public byte ChaosPoints;      // 30					= 1
        public byte CurrentKill;      // 31					= 1
        public short TotalKill;       // 32 a 33		= 2

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public short[] Equip;       // 34 a 65		= 32

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public SAffectMin[] Affect; // 66 a 129		= 64

        public byte GuildIndexEFV2;   // 130				= 1
        public byte GuildIndexEFV1;   // 131				= 1

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] Unk1;         // 132 a 135	= 4

        public SStatus Status;        // 136 a 183	= 48

        public EnterVision SpawnType; // 184				= 1
        public byte SpawnMemberType;  // 185				= 1

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] Anct;         // 186 a 201	= 16

        [XmlIgnore]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 26)]
        public byte[] TabBytes;     // 202 a 227	= 26

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] Unk2;         // 228 a 231	= 4

        // Ajudantes
        public string Name
        {
            get => Functions.GetString(this.NameBytes);
            set
            {
                this.NameBytes = Config.Encoding.GetBytes(value);
                Array.Resize(ref this.NameBytes, 16);
            }
        }
        public string Tab
        {
            get => Functions.GetString(this.TabBytes);
            set
            {
                this.TabBytes = Config.Encoding.GetBytes(value);
                Array.Resize(ref this.TabBytes, 26);
            }
        }

        // Construtores
        public static P_364 New(SMob mob, EnterVision SpawnType)
        {

            P_364 tmp = new P_364
            {
                Header = SHeader.New(0x364, Marshal.SizeOf<P_364>(), mob.ClientId),

                Position = mob.LastPosition,

                ClientId = mob.ClientId,

                Name = mob.Name,

                ChaosPoints = mob.ChaosPoints,
                CurrentKill = mob.CurrentKill,
                TotalKill = mob.TotalKill,

                Equip = new short[16],

                Affect = new SAffectMin[32],

                GuildIndexEFV2 = 0,
                GuildIndexEFV1 = 0,

                Unk1 = new byte[4] { 0, 0, 0, 0 },

                Status = mob.GameStatus,

                SpawnType = SpawnType,
                SpawnMemberType = 0,

                Anct = new byte[16],

                Tab = mob.Tab,

                Unk2 = new byte[] { 0, 0, 0, 0 }
            };

            for (int i = 0; i < tmp.Equip.Length; i++) { tmp.Equip[i] = Functions.GetVisualItemCode(mob.Equip[i], i == 14); }
            for (int i = 0; i < tmp.Affect.Length; i++) { tmp.Affect[i] = SAffectMin.New(mob.Affects[i]); }
            for (int i = 0; i < tmp.Anct.Length; i++) { tmp.Anct[i] = Functions.GetVisualAnctCode(mob.Equip[i]); }

            return tmp;
        }

        public static void UpdateClientVisaoMob(Client client)
        {
            short p1x, p1y, p2x, p2y;
            double ctOposto, ctAdjacente, hipotenusa;

            foreach (SMobList mob in Config.MobList)
            {
                p1x = client.Character.Mob.LastPosition.X;
                p1y = client.Character.Mob.LastPosition.Y;
                p2x = mob.PositionInicial.X;
                p2y = mob.PositionInicial.Y;

                ctOposto = p1x - p2x;
                ctAdjacente = p1y - p2y;

                hipotenusa = Math.Sqrt((ctOposto * ctOposto) + (ctAdjacente * ctAdjacente));

                if (hipotenusa < 30)
                {
                    if (mob.Mob.BaseStatus.CurHP > 0)
                    {
                        if (client.MobView.Where(a => a.Mob.ClientId == mob.Mob.ClientId).Count() == 0)
                        {
                            client.MobView.Add(mob);
                            client.Send(P_364.New(mob.Mob, EnterVision.Normal));
                        }

                    }
                }
                else
                {
                    if (client.MobView.Where(a => a.Mob.ClientId == mob.Mob.ClientId).Count() > 0)
                    {
                        client.MobView.Remove(mob);
                        client.Send(P_165.New(mob.Mob.ClientId, LeaveVision.Normal));
                    }
                }
            }
        }
    }
}