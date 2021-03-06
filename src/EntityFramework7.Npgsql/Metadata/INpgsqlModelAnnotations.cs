﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using JetBrains.Annotations;
using Microsoft.Data.Entity.Metadata;

namespace EntityFramework7.Npgsql.Metadata
{
    public interface INpgsqlModelAnnotations : IRelationalModelAnnotations
    {
        [CanBeNull]
        string DefaultSequenceName { get; }

        [CanBeNull]
        string DefaultSequenceSchema { get; }
    }
}
