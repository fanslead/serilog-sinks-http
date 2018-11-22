﻿using System;
using Serilog.Core;
using Serilog.Sinks.Http.BatchFormatters;
using Serilog.Sinks.Http.TextFormatters;
using Serilog.Support;

namespace Serilog
{
    public class DurableHttpSinkGivenCodeConfigurationShould : SinkFixture
    {
        public DurableHttpSinkGivenCodeConfigurationShould()
        {
            DeleteBufferFiles();

#pragma warning disable CS0618 // Type or member is obsolete

            Logger = new LoggerConfiguration()
                .MinimumLevel.Verbose()
                .WriteTo
                .DurableHttp(
                    requestUri: "some/route",
                    batchPostingLimit: 100,
                    period: TimeSpan.FromMilliseconds(1),
                    textFormatter: new NormalRenderedTextFormatter(),
                    batchFormatter: new DefaultBatchFormatter(),
                    httpClient: new HttpClientMock())
                .CreateLogger();

#pragma warning restore CS0618 // Type or member is obsolete
        }

        protected override Logger Logger { get; }
    }
}
