<template>
  <button class="burger-wrapper" @click="jopa">
    <span class="burger-line"></span>
    <span class="burger-line"></span>
    <span class="burger-line"></span>
  </button>
</template>

<script>
export default {
  
  methods: {
    jopa() {
      console.log('jopa jopa jopa');
    },
  }
}
</script>

<style scoped lang="sass">
.burger-wrapper
  position: absolute
  width: 40px
  height: 40px
  background: none
  border: solid 3px rgb(25, 32, 69)
  border-radius: 100%
  right: 50px
  display: flex
  justify-content: space-around
  flex-direction: column
  align-items: center
  padding: 8px 0
  &:hover
    cursor: pointer
.burger-line
  display: block
  height: 3px
  width: 25px
  background-color: rgb(25, 32, 69)
  transition: 0.5s all
  // &:before
  //   content: ''
  //   position: absolute
  //   background-color: rgb(25, 32, 69)
  //   transition: 0.5s all
  //   height: 3px
  //   width: 35px
  //   margin-top: 5px
  // &::after
  //   content: ''
  //   position: absolute
  //   background-color: rgb(25, 32, 69)
  //   transition: 0.5s all
  //   height: 3px
  //   width: 35px
  //   margin-top: 10px
</style>