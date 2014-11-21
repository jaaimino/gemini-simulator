main:
  add #$5
  add #$2
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