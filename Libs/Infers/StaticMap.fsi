﻿namespace Infers

/// Represents a kind of static mapping of types to values.
///
/// A single value of type `'v` can be stored for a type of `'k`.  A module
/// typically gives some private type for `'k' and then stores unique values
/// for many types `'v`.
type [<Sealed>] StaticMap<'k, 'v> =
  /// Gets the value.  If the value has not been previously set, then the
  /// value stored is the `default` value for that type.
  static member Get: unit -> 'v

  /// Sets the value.
  static member Set: value: 'v -> unit
