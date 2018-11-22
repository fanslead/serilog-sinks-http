﻿// Copyright 2015-2018 Serilog Contributors
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System.Net.Http;
using System.Threading.Tasks;

namespace Serilog.Sinks.Http.Private.Network
{
    public class DefaultHttpClient : IHttpClient
    {
        private readonly HttpClient client;

        public DefaultHttpClient() =>
            client = new HttpClient();

        public Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content) =>
            client.PostAsync(requestUri, content);

        public void Dispose() =>
            client.Dispose();
    }
}
