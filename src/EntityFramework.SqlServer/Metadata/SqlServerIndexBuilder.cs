// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using JetBrains.Annotations;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.SqlServer.Utilities;

namespace Microsoft.Data.Entity.SqlServer.Metadata
{
    public class SqlServerIndexBuilder
    {
        private readonly Index _index;

        public SqlServerIndexBuilder([NotNull] Index index)
        {
            Check.NotNull(index, "index");

            _index = index;
        }

        public virtual SqlServerIndexBuilder Name([CanBeNull] string name)
        {
            Check.NullButNotEmpty(name, "name");

            _index.SqlServer().Name = name;

            return this;
        }
    }
}
