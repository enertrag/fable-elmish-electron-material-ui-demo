module App

open Fable.React
open Fable.React.Props

type Model = int32

type Message =
    | Increment
    | Decrement
    | Double
    | Half

let init (): Model = 0

let view (model: Model) (dispatch: Message -> unit) =
    let buttons =
        [ ("+1", Increment)
          ("-1", Decrement)
          ("*2", Double)
          ("/2", Half) ]
        |> List.map (fun (label, message) ->
            button [ OnClick(fun _ -> dispatch message) ] [
                str label
            ])

    let counter = div [] [ model.ToString() |> str ]
    div [] (counter :: buttons)

let update (message: Message) (model: Model): Model =
    match message with
    | Decrement -> model - 1
    | Increment -> model + 1
    | Double -> model * 2
    | Half -> model / 2
