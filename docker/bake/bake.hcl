group "default" {
  targets = ["actions-test"]
}

target "actions-test" {
  matrix = {
    stage = ["alpine-base", "ubuntu-base"]
  }
  dockerfile = "./Dockerfile"
  name = "actions-test-${stage}"
  target = "${stage}"
  tags = [ "ghcr.io/27cobalter/actions-test/${stage}:latest" ]
}