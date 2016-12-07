[<Fable.Core.Erase>]
module Fable.Helpers.ReduxThunk

open Fable.Import

[<Fable.Core.Erase>]
type ThunkDU =
    | Thunk of (ReactRedux.Dispatcher -> Fable.Import.JS.Promise<unit>)
    interface ReactRedux.IDispatchable

let asThunk (fn : (ReactRedux.Dispatcher -> Fable.Import.JS.Promise<unit>)) : ReactRedux.IDispatchable =
    ThunkDU.Thunk fn |> unbox<ReactRedux.IDispatchable>
