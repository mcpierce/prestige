/*
 * Prestige - A digital comic book reader application.
 * Copyright (C) 2023, The ComiXed Project
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program. If not, see <http://www.gnu.org/licenses>
 */

using System;

namespace prestige
{
    public class OPDSServerEntry
    {
        public OPDSServerEntry(string name, string url, string username, string password)
        {
            this.Name = name;
            this.Url = url;
            this.Username = username;
            this.Password = password;
        }

        public string Name { get; set; }

        public string Url { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime LastAccessedOn { get; set; }
    }
}

