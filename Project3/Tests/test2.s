main:
  add #$1
  add #$1
  ba test
  add #$7
  add #$100
  add #$6
test:
  add #$1
  ba done
  add #$200
done:
  add #$1