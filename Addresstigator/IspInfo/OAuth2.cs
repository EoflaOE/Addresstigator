/*
 * MIT License
 *
 * Copyright (c) 2021 - 2022 EoflaOE and its companies
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 * 
 */

using System.Xml.Serialization;

namespace Addresstigator
{

	/// <summary>
	/// The OAuth2 information for the ISP's mail server
	/// </summary>
    [XmlRoot(ElementName = "oAuth2")]
    public class OAuth2
    {
		/// <summary>
		/// The authentication issuer
		/// </summary>
		[XmlElement(ElementName = "issuer")]
		public string Issuer { get; }

		/// <summary>
		/// The authentication scope
		/// </summary>
		[XmlElement(ElementName = "scope")]
		public string Scope { get; }

		/// <summary>
		/// The authentication URL
		/// </summary>
		[XmlElement(ElementName = "authURL")]
		public string AuthURL { get; }

		/// <summary>
		/// The OAuth2 token URL
		/// </summary>
		[XmlElement(ElementName = "tokenURL")]
		public string TokenURL { get; }
	}

}