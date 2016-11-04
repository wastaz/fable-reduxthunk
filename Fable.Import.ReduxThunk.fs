namespace Fable.Import

open Fable.Core
open Fable.Import

module ReduxThunk =
    type Globals =
        [<Emit("$0.default")>] member __.middleware : ((Redux.IUntypedStore) -> (obj -> unit) -> obj -> unit) = jsNative

[<AutoOpen>]
module ReduxThunk_Extensions =
    let [<Import("*", "redux-thunk")>] ReduxThunk : ReduxThunk.Globals = failwith "JS only"