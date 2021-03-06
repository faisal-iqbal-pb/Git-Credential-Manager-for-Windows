﻿/**** Git Credential Manager for Windows ****
 * 
 * Copyright (c) Microsoft Corporation
 * All rights reserved.
 * 
 * MIT License
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the """"Software""""), to deal
 * in the Software without restriction, including without limitation the rights to
 * use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
 * the Software, and to permit persons to whom the Software is furnished to do so,
 * subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
 * FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
 * COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN
 * AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
 * WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE."
**/

namespace Microsoft.Alm.Authentication
{
    public enum TokenType
    {
        Unknown = 0,
        /// <summary>
        /// Azure Directory Access Token
        /// </summary>
        [System.ComponentModel.Description("Azure Directory Access Token")]
        Access,
        /// <summary>
        /// Azure Directory Refresh Token
        /// </summary>
        [System.ComponentModel.Description("Azure Directory Refresh Token")]
        Refresh,
        /// <summary>
        /// Personal Access Token, can be compact or not.
        /// </summary>
        [System.ComponentModel.Description("Personal Access Token")]
        Personal,
        /// <summary>
        /// Federated Authentication (aka FedAuth) Token
        /// </summary>
        [System.ComponentModel.Description("Federated Authentication Token")]
        Federated,
        /// <summary>
        /// Used only for testing
        /// </summary>
        [System.ComponentModel.Description("Test-only Token")]
        Test,
    }
}
