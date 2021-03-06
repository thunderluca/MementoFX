﻿using MementoFX.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoFX.Tests.Assets.Model
{
    public class SnapshotSupportingCurrentAccount : CurrentAccount, ISupportSnapshots
    {
        IAggregateMemento ISupportSnapshots.CreateMemento()
        {
            return base.CreateMemento();
        }

        public void Restore(IAggregateMemento memento)
        {
            throw new NotImplementedException();
        }
    }
}
