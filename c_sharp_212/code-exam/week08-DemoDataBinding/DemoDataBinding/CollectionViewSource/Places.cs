﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionViewSource
{
    internal class Places : ObservableCollection<Place>
    {
        public Places()
        {
            Add(new Place("Seattle", "WA"));
            Add(new Place("Redmond", "WA"));
            Add(new Place("Bellevue", "WA"));
            Add(new Place("Kirkland", "WA"));
            Add(new Place("Portland", "OR"));
            Add(new Place("San Francisco", "CA"));
            Add(new Place("Los Angeles", "CA"));
            Add(new Place("San Diego", "CA"));
            Add(new Place("San Jose", "CA"));
            Add(new Place("Santa Ana", "CA"));
            Add(new Place("Bellingham", "WA"));
        }
    }
}
