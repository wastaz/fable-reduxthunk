# fable-reduxthunk

Fable bindings for [redux-thunk](https://github.com/gaearon/redux-thunk). 

This package is intended to be used together with my redux bindings [Fable-redux](https://github.com/wastaz/fable-redux)
and also contains extra helpers for working together with my opinionated react-redux bindings,
however they are also usable without the opinionated react-redux binding if those are not to
your liking.

## Installation

    $ npm install --save redux redux-thunk fable-core
    $ npm install --save-dev fable-redux fable-reduxthunk

## Usage

In a F# project (.fsproj)

    <ItemGroup>
        <Reference Include="node_modules/fable-core/Fable.Core.dll" />
        <Reference Include="node_modules/fable-redux/Fable.Redux.dll" />
        <Reference Include="node_modules/fable-reduxthunk/Fable.ReduxThunk.dll" />
    </ItemGroup>

## Related projects

Apart from [Fable-redux](https://github.com/wastaz/fable-redux) which is a
dependency you may also want to have a look at my quite opinionated fable bindings for 
[react-redux](https://github.com/reactjs/react-redux) as well as the excellent 
react bindings [fable-react](https://www.npmjs.com/package/fable-react).

I personally recommend using them all together, but these bindings should also be useful on their own.


## License 

MIT, feel free to fork and/or send pull requests :)