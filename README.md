# fable-import-reduxthunk

Fable bindings for [redux-thunk](https://github.com/gaearon/redux-thunk). 

This package is intended to be used together with my redux bindings [Fable-import-redux](https://github.com/wastaz/fable-import-redux)
and also contains extra helpers for working together with my opinionated react-redux bindings,
however they are also usable without the opinionated react-redux binding if those are not to
your liking.

## Installation

    $ npm install --save redux redux-thunk fable-core
    $ npm install --save-dev fable-import-redux fable-import-reduxthunk

## Usage

In a F# project (.fsproj)

    <ItemGroup>
        <!-- Normal imports, usable without fable-import-reactredux-opinionated -->
        <Compile Include="node_modules/fable-import-reduxthunk/Fable.Import.ReduxThunk.fs" />
    </ItemGroup>
    <ItemGroup>
        <!-- Only include this file if you are also using fable-import-reactredux-opinionated! -->
        <Compile Include="node_modules/fable-import-reduxthunk/Fable.Helpers.ReactRedux.ReduxThunk.fs" />
    </ItemGroup>

## Related projects

Apart from [Fable-import-redux](https://github.com/wastaz/fable-import-redux) which is a
dependency you may also want to have a look at my quite opinionated fable bindings for 
[react-redux](https://github.com/reactjs/react-redux) as well as the excellent 
react bindings [fable-import-react](https://www.npmjs.com/package/fable-import-react).

I personally recommend using them all together, but these bindings should also be useful on their own.


## License 

MIT, feel free to fork and/or send pull requests :)