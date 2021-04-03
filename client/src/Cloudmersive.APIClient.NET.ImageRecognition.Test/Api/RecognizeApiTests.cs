/* 
 * imageapi
 *
 * Image Recognition and Processing APIs let you use Machine Learning to recognize and process images, and also perform useful image modification operations.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Cloudmersive.APIClient.NET.ImageRecognition.Client;
using Cloudmersive.APIClient.NET.ImageRecognition.Api;
using Cloudmersive.APIClient.NET.ImageRecognition.Model;

namespace Cloudmersive.APIClient.NET.ImageRecognition.Test
{
    /// <summary>
    ///  Class for testing RecognizeApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class RecognizeApiTests
    {
        private RecognizeApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new RecognizeApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of RecognizeApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' RecognizeApi
            //Assert.IsInstanceOfType(typeof(RecognizeApi), instance, "instance is a RecognizeApi");
        }

        
        /// <summary>
        /// Test RecognizeDescribe
        /// </summary>
        [Test]
        public void RecognizeDescribeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream imageFile = null;
            //var response = instance.RecognizeDescribe(imageFile);
            //Assert.IsInstanceOf<ImageDescriptionResponse> (response, "response is ImageDescriptionResponse");
        }
        
        /// <summary>
        /// Test RecognizeDetectAndUnskewDocument
        /// </summary>
        [Test]
        public void RecognizeDetectAndUnskewDocumentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream imageFile = null;
            //string postProcessingEffect = null;
            //var response = instance.RecognizeDetectAndUnskewDocument(imageFile, postProcessingEffect);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test RecognizeDetectObjects
        /// </summary>
        [Test]
        public void RecognizeDetectObjectsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream imageFile = null;
            //var response = instance.RecognizeDetectObjects(imageFile);
            //Assert.IsInstanceOf<ObjectDetectionResult> (response, "response is ObjectDetectionResult");
        }
        
        /// <summary>
        /// Test RecognizeDetectPeople
        /// </summary>
        [Test]
        public void RecognizeDetectPeopleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream imageFile = null;
            //var response = instance.RecognizeDetectPeople(imageFile);
            //Assert.IsInstanceOf<ObjectDetectionResult> (response, "response is ObjectDetectionResult");
        }
        
        /// <summary>
        /// Test RecognizeDetectTextFine
        /// </summary>
        [Test]
        public void RecognizeDetectTextFineTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream imageFile = null;
            //var response = instance.RecognizeDetectTextFine(imageFile);
            //Assert.IsInstanceOf<FineTextDetectionResult> (response, "response is FineTextDetectionResult");
        }
        
        /// <summary>
        /// Test RecognizeDetectTextLarge
        /// </summary>
        [Test]
        public void RecognizeDetectTextLargeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream imageFile = null;
            //var response = instance.RecognizeDetectTextLarge(imageFile);
            //Assert.IsInstanceOf<TextDetectionResult> (response, "response is TextDetectionResult");
        }
        
        /// <summary>
        /// Test RecognizeDetectVehicleLicensePlates
        /// </summary>
        [Test]
        public void RecognizeDetectVehicleLicensePlatesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream imageFile = null;
            //var response = instance.RecognizeDetectVehicleLicensePlates(imageFile);
            //Assert.IsInstanceOf<VehicleLicensePlateDetectionResult> (response, "response is VehicleLicensePlateDetectionResult");
        }
        
        /// <summary>
        /// Test RecognizeFindSymbol
        /// </summary>
        [Test]
        public void RecognizeFindSymbolTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputImage = null;
            //System.IO.Stream targetImage = null;
            //var response = instance.RecognizeFindSymbol(inputImage, targetImage);
            //Assert.IsInstanceOf<FindSymbolResult> (response, "response is FindSymbolResult");
        }
        
        /// <summary>
        /// Test RecognizeSimilarityCompare
        /// </summary>
        [Test]
        public void RecognizeSimilarityCompareTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream baseImage = null;
            //System.IO.Stream comparisonImage = null;
            //string recognitionMode = null;
            //var response = instance.RecognizeSimilarityCompare(baseImage, comparisonImage, recognitionMode);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test RecognizeSimilarityHash
        /// </summary>
        [Test]
        public void RecognizeSimilarityHashTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream imageFile = null;
            //string recognitionMode = null;
            //var response = instance.RecognizeSimilarityHash(imageFile, recognitionMode);
            //Assert.IsInstanceOf<ImageSimilarityHashResponse> (response, "response is ImageSimilarityHashResponse");
        }
        
        /// <summary>
        /// Test RecognizeSimilarityHashDistance
        /// </summary>
        [Test]
        public void RecognizeSimilarityHashDistanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ImageSimilarityHashDistanceRequest request = null;
            //var response = instance.RecognizeSimilarityHashDistance(request);
            //Assert.IsInstanceOf<ImageSimilarityHashDistanceResponse> (response, "response is ImageSimilarityHashDistanceResponse");
        }
        
    }

}
