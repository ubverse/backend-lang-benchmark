package accumulator

type acc struct {
	hits int
	acc  int
}

func New() *acc {
	return &acc{
		hits: 0,
		acc:  0,
	}
}

func (a *acc) alter(val int) {
	a.hits += 1
	a.acc += val
}

func (a *acc) Inc(val int) {
	a.alter(val)
}

func (a *acc) Dec(val int) {
	a.alter(0 - val)
}

func (a *acc) Get() (int, int) {
	return a.hits, a.acc
}
