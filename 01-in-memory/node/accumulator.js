module.exports = (function () {
    let hits = 0
    let acc = 0

    function alter (v) {
        hits++
        acc += v
    }

    return {
        inc: (v = 1) => alter(v),
        dec: (v = 1) => alter(0 - v),
        get: () => ({ hits, acc }),
    }
})()
