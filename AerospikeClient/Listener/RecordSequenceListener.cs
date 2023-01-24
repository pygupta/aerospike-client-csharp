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
	/// Asynchronous result notifications for batch get and scan commands.
	/// The results are sent one record at a time.
	/// </summary>
	public interface RecordSequenceListener
	{
		/// <summary>
		/// This method is called when an asynchronous record is received from the server.
		/// The receive sequence is not ordered.
		/// <para>
		/// This method is not thread-safe. Multiple async completion port threads may be calling
		/// this listener method simultaneously. All shared data in the callback must be handled 
		/// in a thread-safe manner.
		/// </para>
		/// <para>
		/// The user may throw a 
		/// <seealso cref="Aerospike.Client.AerospikeException.QueryTerminated"/> 
		/// exception if the command should be aborted.  If any exception is thrown, parallel command threads
		/// to other nodes will also be terminated and the exception will be propagated back through the
		/// commandFailed() call.
		/// </para>
		/// </summary>
		/// <param name="key">unique record identifier </param>
		/// <param name="record">record instance, will be null if the key is not found</param>
		/// <exception cref="AerospikeException">if error occurs or scan should be terminated.</exception>
		void OnRecord(Key key, Record record);

		/// <summary>
		/// This method is called when the asynchronous batch get or scan command completes.
		/// </summary>
		void OnSuccess();

		/// <summary>
		/// This method is called when an asynchronous batch get or scan command fails.
		/// </summary>
		/// <param name="exception">error that occurred</param>
		void OnFailure(AerospikeException exception);
	}
}
