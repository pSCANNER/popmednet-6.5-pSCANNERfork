﻿using Lpp.Dns.DataMart.Model;
using Lpp.Scanner.DataMart.Model.Processors.Analysis;
using Lpp.Scanner.DataMart.Model.Processors.Common.Processor.Task;
using Moq;
using NUnit.Framework;
using pSCANNER.DataMart.Model.processor.Analysis;
using System;
using
using System.IO;
using System.Collections.Generic;

namespace Test.Lpp.pScanner.DataMart.Model.Processors.Processor {

    /// <summary>
    /// </summary>
    [TestFixture]
    internal class TestScannerAnalysisModelProcessor {

        /// <summary>
        ///     Initializes the test.
        /// </summary>
        [OneTimeSetUp]
        public void InitializeTest() {
            _processor = new ScannerAnalysisModelProcessor(new MockScannerAnalysisModelProcessor<AsyncTask>(), new ScannerAnalysisModelMetadata());
            _network = new NetworkConnectionMetadata {
                OrganizationName = "",
                UserEmail = "",
                UserFullName = "",
                UserLogin = ""
            };
            _requestMetadata = new RequestMetadata {
            };
            _requestDocuments = new Document[] { };
        }

        /// <summary>
        ///     Requests the documents empty test.
        /// </summary>
        [Test]
        public void Request_Documents_Empty_Test() {
            Assert.That(() => _processor.Request(It.IsAny<String>(), It.IsAny<NetworkConnectionMetadata>(), It.IsAny<RequestMetadata>(), null, out IDictionary<string, string> requestProperties, out Document[] desiredDocuments),
                Throws.Exception.TypeOf<ArgumentNullException>().With.Property("ParamName").EqualTo("Document[]"));

            Assert.That(() => _processor.Request(It.IsAny<String>(), It.IsAny<NetworkConnectionMetadata>(), It.IsAny<RequestMetadata>(), new Document[] { }, out IDictionary<string, string> requestProperties, out Document[] desiredDocuments),
               Throws.Exception.TypeOf<ArgumentNullException>().With.Property("ParamName").EqualTo("Document[]"));
        }

        /// <summary>
        ///     Requests the network connection metadata empty test.
        /// </summary>
        [Test]
        public void Request_NetworkConnectionMetadata_Empty_Test() {
            Assert.That(() => _processor.Request(It.IsAny<String>(), null, It.IsAny<RequestMetadata>(), It.IsAny<Document[]>(), out IDictionary<string, string> requestProperties, out Document[] desiredDocuments),
                Throws.Exception.TypeOf<ArgumentNullException>().With.Property("ParamName").EqualTo("NetworkConnectionMetadata"));
        }

        /// <summary>
        ///     Requests the request identifier empty test.
        /// </summary>
        [Test]
        public void Request_RequestId_Empty_Test() {
            Assert.That(() => _processor.Request(null, It.IsAny<NetworkConnectionMetadata>(), It.IsAny<RequestMetadata>(), It.IsAny<Document[]>(), out IDictionary<string, string> requestProperties, out Document[] desiredDocuments), Throws.Exception.TypeOf<ArgumentNullException>().With.Property("ParamName").EqualTo("RequestId"));
            Assert.That(() => _processor.Request(string.Empty, It.IsAny<NetworkConnectionMetadata>(), It.IsAny<RequestMetadata>(), It.IsAny<Document[]>(), out IDictionary<string, string> requestProperties, out Document[] desiredDocuments), Throws.Exception.TypeOf<ArgumentNullException>().With.Property("ParamName").EqualTo("RequestId"));
            Assert.That(() => _processor.Request("", It.IsAny<NetworkConnectionMetadata>(), It.IsAny<RequestMetadata>(), It.IsAny<Document[]>(), out IDictionary<string, string> requestProperties, out Document[] desiredDocuments), Throws.Exception.TypeOf<ArgumentNullException>().With.Property("ParamName").EqualTo("RequestId"));
        }

        /// <summary>
        ///     Requests the request metadata empty test.
        /// </summary>
        [Test]
        public void Request_RequestMetadata_Empty_Test() {
            Assert.That(() => _processor.Request(It.IsAny<String>(), It.IsAny<NetworkConnectionMetadata>(), null, It.IsAny<Document[]>(), out IDictionary<string, string> requestProperties, out Document[] desiredDocuments), Throws.Exception.TypeOf<ArgumentNullException>().With.Property("ParamName").EqualTo("RequestMetadata"));
        }

        /// <summary>
        ///     Requests the test.
        /// </summary>
        [Test]
        public void Request_Test() {
            _processor.Request(It.IsAny<String>(), _network, _requestMetadata, _requestDocuments, out IDictionary<string, string> requestProperties, out Document[] desiredDocuments);
        }

        //[Test]
        /// <summary>
        ///     Requests the document content stream empty test.
        /// </summary>
        public void RequestDocument_ContentStream_Empty_Test() {
            Assert.That(() => _processor.RequestDocument(It.IsAny<String>(), It.IsAny<String>(), null), Throws.Exception.TypeOf<ArgumentException>().With.Property("ParamName").EqualTo("contentStream"));
        }

        //[Test]
        /// <summary>
        ///     Requests the document document identifier empty test.
        /// </summary>
        public void RequestDocument_DocumentId_Empty_Test() {
            Assert.That(() => _processor.RequestDocument(It.IsAny<String>(), null, It.IsAny<Stream>()), Throws.Exception.TypeOf<ArgumentException>().With.Property("ParamName").EqualTo("documentId"));
            Assert.That(() => _processor.RequestDocument(It.IsAny<String>(), string.Empty, It.IsAny<Stream>()), Throws.Exception.TypeOf<ArgumentException>().With.Property("ParamName").EqualTo("documentId"));
            Assert.That(() => _processor.RequestDocument(It.IsAny<String>(), "", It.IsAny<Stream>()), Throws.Exception.TypeOf<ArgumentException>().With.Property("ParamName").EqualTo("documentId"));
        }

        //[Test]
        /// <summary>
        ///     Requests the document request identifier empty test.
        /// </summary>
        public void RequestDocument_RequestId_Empty_Test() {
            Assert.That(() => _processor.RequestDocument(null, It.IsAny<String>(), It.IsAny<Stream>()), Throws.Exception.TypeOf<ArgumentException>().With.Property("ParamName").EqualTo("requestId"));
            Assert.That(() => _processor.RequestDocument(string.Empty, It.IsAny<String>(), It.IsAny<Stream>()), Throws.Exception.TypeOf<ArgumentException>().With.Property("ParamName").EqualTo("requestId"));
            Assert.That(() => _processor.RequestDocument("", It.IsAny<String>(), It.IsAny<Stream>()), Throws.Exception.TypeOf<ArgumentException>().With.Property("ParamName").EqualTo("requestId"));
        }

        /// <summary>
        ///     Tests this instance.
        /// </summary>
        //[Test]
        public void RequestDocument_Test() {
            string requestId = It.IsAny<String>();
            string documentId = It.IsAny<String>();
            var contentStream = new Mock<Stream>();
            _processor.RequestDocument(requestId, documentId, contentStream.Object);
        }

        /// <summary>
        ///     Tests the response document.
        /// </summary>
        //[Test]
        public void ResponseDocument_Test() {
            string requestId = It.IsAny<String>();
            string documentId = It.IsAny<String>();
            int maxSize = It.IsAny<int>();
            _processor.ResponseDocument(requestId, documentId, out Stream contentStream, maxSize);
        }

        /// <summary>
        ///     Tears down.
        /// </summary>
        [OneTimeTearDown]
        public void TearDown() {
            _processor = null;
        }

        /// <summary>
        ///     The network
        /// </summary>
        private NetworkConnectionMetadata _network;

        /// <summary>
        ///     The processor
        /// </summary>
        private ScannerAnalysisModelProcessor _processor;

        /// <summary>
        ///     The request documents
        /// </summary>
        private Document[] _requestDocuments;

        /// <summary>
        ///     The request metadata
        /// </summary>
        private RequestMetadata _requestMetadata;
    }
}