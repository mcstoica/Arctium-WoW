﻿/*
 * Copyright (C) 2012-2015 Arctium Emulation <http://arctium.org>
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using Framework.Objects;

namespace World.Shared.Game.Entities.Object.Guid
{
    class CreatureGuid : SmartGuid
    {
        public ushort RealmId
        {
            get { return (ushort)((High >> 42) & 0x1FFF); }
            set { High |= (ulong)value << 42; }
        }

        public ushort MapId
        {
            get { return (ushort)((High >> 29) & 0x1FFF); }
            set { High |= (ulong)value << 29; }
        }

        public ushort ServerId
        {
            get { return (ushort)((Low >> 40) & 0xFFFF); }
            set { Low |= (ulong)value << 40; }
        }

        public uint Id
        {
            get { return (uint)(High & 0x7FFFFF) >> 6; }
            set { High |= (ulong)value << 6; }
        }

        public ulong CreationBits
        {
            get { return Low & 0xFFFFFFFFFF; }
            set { Low |= value; }
        }
    }
}
