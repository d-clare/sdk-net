// Copyright © 2025-Present The DClare Authors
//
// Licensed under the Apache License, Version 2.0 (the "License"),
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace DClare.Sdk;

/// <summary>
/// Represents a discriminated union that can hold a value of either <typeparamref name="T1"/> or <typeparamref name="T2"/>.
/// </summary>
/// <typeparam name="T1">The first supported type.</typeparam>
/// <typeparam name="T2">The second supported type.</typeparam>
[DataContract, JsonConverter(typeof(JsonOneOfConverter))]
public class OneOf<T1, T2>
    : IOneOf
{

    /// <summary>
    /// Initializes the union with a value of type <typeparamref name="T1"/>.
    /// </summary>
    /// <param name="value">The value to store.</param>
    public OneOf(T1 value)
    {
        TypeIndex = 1;
        T1Value = value!;
    }

    /// <summary>
    /// Initializes the union with a value of type <typeparamref name="T2"/>.
    /// </summary>
    /// <param name="value">The value to store.</param>
    public OneOf(T2 value)
    {
        TypeIndex = 2;
        T2Value = value!;
    }

    /// <summary>
    /// Gets the index of the stored type: 1 for <typeparamref name="T1"/>, 2 for <typeparamref name="T2"/>.
    /// </summary>
    public int TypeIndex { get; }

    /// <summary>
    /// Gets the value if it is of type <typeparamref name="T1"/>, or <c>null</c> otherwise.
    /// </summary>
    [DataMember(Order = 1), JsonIgnore, YamlIgnore]
    public T1? T1Value { get; }

    /// <summary>
    /// Gets the value if it is of type <typeparamref name="T2"/>, or <c>null</c> otherwise.
    /// </summary>
    [DataMember(Order = 2), JsonIgnore, YamlIgnore]
    public T2? T2Value { get; }

    object? IOneOf.GetValue() => this.TypeIndex switch
    {
        1 => T1Value,
        2 => T2Value,
        _ => null
    };

    /// <summary>
    /// Implicitly converts a value of type <typeparamref name="T1"/> to a <see cref="OneOf{T1, T2}"/>.
    /// </summary>
    public static implicit operator OneOf<T1, T2>(T1 value) => new(value);

    /// <summary>
    /// Implicitly converts a value of type <typeparamref name="T2"/> to a <see cref="OneOf{T1, T2}"/>.
    /// </summary>
    public static implicit operator OneOf<T1, T2>(T2 value) => new(value);

    /// <summary>
    /// Implicitly converts a <see cref="OneOf{T1, T2}"/> to its value of type <typeparamref name="T1"/>, if applicable.
    /// </summary>
    public static implicit operator T1?(OneOf<T1, T2> value) => value.T1Value;

    /// <summary>
    /// Implicitly converts a <see cref="OneOf{T1, T2}"/> to its value of type <typeparamref name="T2"/>, if applicable.
    /// </summary>
    public static implicit operator T2?(OneOf<T1, T2> value) => value.T2Value;

}
