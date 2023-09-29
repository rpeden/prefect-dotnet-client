/*
 * Prefect API Client for .NET
 *
 * For more information, visit: https://github.com/rpeden/prefect-client-dotnet
 *
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using Xunit;

using PrefectClient.Client;
using PrefectClient.Api;
// uncomment below to import models
//using PrefectClient.Model;

namespace PrefectClient.Test.Api
{
    /// <summary>
    ///  Class for testing BlockSchemasApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class BlockSchemasApiTests : IDisposable
    {
        private BlockSchemasApi instance;

        public BlockSchemasApiTests()
        {
            instance = new BlockSchemasApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of BlockSchemasApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' BlockSchemasApi
            //Assert.IsType<BlockSchemasApi>(instance);
        }

        /// <summary>
        /// Test CreateBlockSchema
        /// </summary>
        [Fact]
        public void CreateBlockSchemaTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BlockSchemaCreate blockSchemaCreate = null;
            //var response = instance.CreateBlockSchema(blockSchemaCreate);
            //Assert.IsType<BlockSchema>(response);
        }

        /// <summary>
        /// Test DeleteBlockSchema
        /// </summary>
        [Fact]
        public void DeleteBlockSchemaTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //instance.DeleteBlockSchema(id);
        }

        /// <summary>
        /// Test ReadBlockSchemaByChecksum
        /// </summary>
        [Fact]
        public void ReadBlockSchemaByChecksumTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string checksum = null;
            //string varVersion = null;
            //var response = instance.ReadBlockSchemaByChecksum(checksum, varVersion);
            //Assert.IsType<BlockSchema>(response);
        }

        /// <summary>
        /// Test ReadBlockSchemaById
        /// </summary>
        [Fact]
        public void ReadBlockSchemaByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //var response = instance.ReadBlockSchemaById(id);
            //Assert.IsType<BlockSchema>(response);
        }

        /// <summary>
        /// Test ReadBlockSchemas
        /// </summary>
        [Fact]
        public void ReadBlockSchemasTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ReadBlockSchemasRequest readBlockSchemasRequest = null;
            //var response = instance.ReadBlockSchemas(readBlockSchemasRequest);
            //Assert.IsType<List<BlockSchema>>(response);
        }
    }
}
