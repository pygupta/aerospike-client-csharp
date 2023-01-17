/* 
 * Copyright 2012-2022 Aerospike, Inc.
 *
 * Portions may be licensed to Aerospike, Inc. under one or more contributor
 * license agreements.
 *
 * Licensed under the Apache License, Version 2.0 (the "License"); you may not
 * use this file except in compliance with the License. You may obtain a copy of
 * the License at http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
 * WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
 * License for the specific language governing permissions and limitations under
 * the License.
 */
namespace Aerospike.Client
{
	/// <summary>
	/// Asynchronous result notifications for batch exists commands.
	/// The results are sent one record at a time.
	/// </summary>
	public interface ExistsSequenceListener
	{
		/// <summary>
		/// This method is called when an asynchronous batch exists result is received from the server.
		/// The receive sequence is not ordered.
		/// <para>
		/// This method is not thread-safe. Multiple async completion port threads may be calling
		/// this listener method simultaneously. All shared data in the callback must be handled 
		/// in a thread-safe manner.
		/// </para>
		/// </summary>
		/// <param name="key">unique record identifier</param>
		/// <param name="exists">whether key exists on server</param>
		void OnExists(Key key, bool exists);

		/// <summary>
		/// This method is called when the asynchronous batch exists command completes.
		/// </summary>
		void OnSuccess();

		/// <summary>
		/// This method is called when an asynchronous batch exists command fails.
		/// </summary>
		/// <param name="exception">error that occurred</param>
		void OnFailure(AerospikeException exception);
	}
}
