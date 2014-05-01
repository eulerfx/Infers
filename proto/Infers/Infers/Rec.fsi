﻿module Infers.Rec

open System
open Infers.Engine

/// Recursion rules for F# functions.
type [<RecursionRules>] RecFun =
  new: unit -> RecFun
  member Tier: ('a -> 'b) -> ref<'a -> 'b>
  member Untie: ref<'a -> 'b> -> ('a -> 'b)
  member Tie: ref<'a -> 'b> * ('a -> 'b) -> unit

/// Recursion rules for nullary .Net `Func` delegates.
type [<RecursionRules>] RecFunc0 =
  new: unit -> RecFunc0
  member Tier: Func<'a> -> ref<Func<'a>>
  member Untie: ref<Func<'a>> -> Func<'a>
  member Tie: ref<Func<'a>> * Func<'a> -> unit

/// Recursion rules for unary .Net `Func` delegates.
type [<RecursionRules>] RecFunc1 =
  new: unit -> RecFunc1
  member Tier: Func<'a, 'b> -> ref<Func<'a, 'b>>
  member Untie: ref<Func<'a, 'b>> -> Func<'a, 'b>
  member Tie: ref<Func<'a, 'b>> * Func<'a, 'b> -> unit

/// Recursion rules for binary .Net `Func` delegates.
type [<RecursionRules>] RecFunc2 =
  new: unit -> RecFunc2
  member Tier: Func<'a, 'b, 'c> -> ref<Func<'a, 'b, 'c>>
  member Untie: ref<Func<'a, 'b, 'c>> -> Func<'a, 'b, 'c>
  member Tie: ref<Func<'a, 'b, 'c>> * Func<'a, 'b, 'c> -> unit