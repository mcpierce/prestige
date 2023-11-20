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

using System.Collections.ObjectModel;
using Windows.UI.Xaml.Controls;

namespace prestige
{
    public sealed partial class MainPage : Page
    {
        public ObservableCollection<OPDSServerEntry> ServerEntries { get; }
         = new ObservableCollection<OPDSServerEntry>();

        public MainPage()
        {
            this.InitializeComponent();

            this.ServerEntries.Add(new OPDSServerEntry("My First Server", "https://localhost:7171/opds", "comixedreader@localhost", "comixedreader"));
            this.ServerEntries.Add(new OPDSServerEntry("My Second Server", "https://localhost:7171/opds", "comixedreader@localhost", "comixedreader"));
            this.ServerEntries.Add(new OPDSServerEntry("My Third Server", "https://localhost:7171/opds", "comixedreader@localhost", "comixedreader"));
            this.ServerEntries.Add(new OPDSServerEntry("My Fourth Server", "https://localhost:7171/opds", "comixedreader@localhost", "comixedreader"));
            this.ServerEntries.Add(new OPDSServerEntry("My Fifth Server", "https://localhost:7171/opds", "comixedreader@localhost", "comixedreader"));
            this.ServerEntries.Add(new OPDSServerEntry("My Sixth Server", "https://localhost:7171/opds", "comixedreader@localhost", "comixedreader"));
            this.ServerEntries.Add(new OPDSServerEntry("My Seventh Server", "https://localhost:7171/opds", "comixedreader@localhost", "comixedreader"));
            this.ServerEntries.Add(new OPDSServerEntry("My Eighth Server", "https://localhost:7171/opds", "comixedreader@localhost", "comixedreader"));

        }
    }
}
