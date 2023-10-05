<template>
  <firstComponent></firstComponent>
  <router-link to="/LKPage" class="router-link">go to</router-link>
</template>

<script>
import firstComponent from '@/components/firstComponent.vue';

export default {
  data() {
    return;
  },
  components: {
    firstComponent,
  }
}
</script>

<style lang="sass" scoped>
.router-link
    margin: 30px
    font-size: 25px
    border: solid 2px
</style>