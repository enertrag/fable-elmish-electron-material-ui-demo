module Entry

open Elmish
open Elmish.React
open Elmish.Debug
open Elmish.HMR

Program.mkSimple App.init App.update App.view
|> Program.withReactSynchronous "app"
#if DEBUG
|> Program.withDebugger
#endif
|> Program.run
