﻿module.exports = {
    mode: 'development',
    context: __dirname,
    entry: {
        index: "./index.jsx",
        Customers: "./Customer.jsx",
        Products: "./Product.jsx",
        Stores: "./Store.jsx",
        Sales: "./Sales.jsx"
    },
    output: {
        path: __dirname + "/dist",
        filename: "[name].bundle.js"
    },
    watch: true,
    module: {
        rules: [{
            test: /\.jsx?$/,
            exclude: /(node_modules)/,
            use: {
                loader: 'babel-loader',
                options: {
                    presets: ['babel-preset-env', 'babel-preset-react']
                }
            }
        }]
    }
}
