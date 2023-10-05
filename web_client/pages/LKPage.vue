<template>
  <div class="wrapper">
    <header class="header">
      <logoComponent></logoComponent>
    </header>
    <div class="container">
      <lkFeaturesComponent></lkFeaturesComponent>
      <burgerComponent></burgerComponent>
    </div>
  </div>
  
</template>

<script>
import logoComponent from '@/components/logoComponent.vue';
import lkFeaturesComponent from '@/components/lkFeaturesComponent.vue';
import burgerComponent from '@/components/burgerComponent.vue';

export default {
  data() {
    return;
  },
  components: {
    logoComponent,
    lkFeaturesComponent,
    burgerComponent,
  }
}
</script>

<style lang="sass" scoped>
.wrapper
  background: rgb(223, 232, 255)
.header
  display: flex
  justify-content: center
  padding: 20px 0

.container
  display: flex
  width: 95%
  margin: 0 auto
</style>