﻿/*
    Copyright 2016-2017 shibboleet
    This file is part of DouBOL Dash.
    DouBOL Dash is free software: you can redistribute it and/or modify it under
    the terms of the GNU General Public License as published by the Free
    Software Foundation, either version 3 of the License, or (at your option)
    any later version.
    DouBOL Dash is distributed in the hope that it will be useful, but WITHOUT ANY
    WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS
    FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.
    You should have received a copy of the GNU General Public License along
    with DouBOL Dash. If not, see http://www.gnu.org/licenses/.
*/
using System.Collections.Generic;
using System.IO;

namespace DouBOLDash
{
    class IKP
    {
        List<IKPEntry> ikpEntry = new List<IKPEntry>();

        public void Parse(EndianBinaryReader reader)
        {

        }

        public List<IKPEntry> returnIKP()
        {
            return ikpEntry;
        }
    }

    public class IKPEntry
    {

    }
}
