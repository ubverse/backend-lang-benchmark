const { createServer, plugins } = require('restify')
const acc = require('./accumulator')

const getQueryValue = (value) => typeof value === 'string' && value.trim().length > 0
    ? (parseInt(value) || 1)
    : 1

const port = 8080
const app = createServer()
    .use(plugins.bodyParser())
    .use(plugins.queryParser())


app.get('/status', (req, res, next) => {
    res.send(200, acc.get())
})

app.post('/increment', (req, res, next) => {
    const value = getQueryValue(req.query.value)
    acc.inc(value)
    res.send(200)
})

app.post('/decrement', (req, res, next) => {
    const value = getQueryValue(req.query.value)
    acc.dec(value)
    res.send(200)
})

app.post('/accumulator', (req, res, next) => {
    const { action, value } = req.body

    switch (action) {
        case 'increment':
            acc.inc(value)
            break

        case 'decrement':
            acc.dec(value)
            break
    }

    res.send(200)
})


app.listen(port, () => console.info(`listening at port ${port}`))
